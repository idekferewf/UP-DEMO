using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShoeStoreLib;
using ShoeStoreLib.Repositories;
using ShoeStoreLib.Services;

namespace ShoeStoreWinForms
{
    public partial class MainForm : Form
    {
        private ProductService productService_;
        private OrderService orderService_;
        private User currentUser_ = null;
        private List<Product> products_ = new List<Product>();

        public MainForm(User user)
        {
            productService_ = new ProductService(new MySQLProductRepository());
            orderService_ = new OrderService(new MySQLOrderRepository());
            currentUser_ = user;
            InitializeComponent();

            products_ = productService_.GetAllProducts();
            FillProducts(products_);
        }

        private void FillProducts(List<Product> products)
        {
            productsListBox.DataSource = null;
            productsListBox.DataSource = products;
            productsListBox.DisplayMember = "DisplayName";
            productCard.Visible = products.Count > 0;
        }

        private void productsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Product product = (Product)productsListBox.SelectedItem;
            if (product == null)
            {
                return;
            }

            productCard.ShowProductInfo(product);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (currentUser_ != null)
            {
                userFioToolStripLabel.Text = currentUser_.Fio;
            }
            else
            {
                userFioToolStripLabel.Text = "Гость";
            }

            if (currentUser_ == null || currentUser_.Role == UserRole.Client)
            {
                searchToolStripTextBox.Enabled = false;
                supplierToolStripComboBox.Enabled = false;
                sortIncQuantityButton.Enabled = false;
                sortDecQuantityButton.Enabled = false;
                showOrdersButton.Enabled = false;
            }

            if (currentUser_ == null || currentUser_.Role != UserRole.Admin)
            {
                addProductButton.Enabled = false;
                deleteProductButton.Enabled = false;
            }

            supplierToolStripComboBox.ComboBox.DataSource = productService_.GetAllSuppliers();
        }

        private bool HasSearchOrFilter()
        {
            return !string.IsNullOrEmpty(searchToolStripTextBox.Text)
                || supplierToolStripComboBox.ComboBox.Text != "Все поставщики";
        }

        private void SearchOrFilterProducts(object sender, EventArgs e)
        {
            if (!HasSearchOrFilter())
            {
                FillProducts(products_);
                return;
            }

            List<Product> result = productService_.SearchAndFilterProducts(
                products_, searchToolStripTextBox.Text, supplierToolStripComboBox.ComboBox.Text);
            FillProducts(result);
        }

        private void sortIncQuantityButton_Click(object sender, EventArgs e)
        {
            products_ = products_.OrderBy(p => p.Quantity).ToList();
            SearchOrFilterProducts(sender, e);
        }

        private void sortDecQuantityButton_Click(object sender, EventArgs e)
        {
            products_ = products_.OrderByDescending(p => p.Quantity).ToList();
            SearchOrFilterProducts(sender, e);
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            AddOrEditProductForm addForm = new AddOrEditProductForm(productService_, null, false);
            DialogResult result = addForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                productService_.AddProduct(addForm.Product);

                products_.Clear();
                products_ = productService_.GetAllProducts();
                FillProducts(products_);

                searchToolStripTextBox.Clear();
            }
        }

        private void productCard_DoubleClick(object sender, EventArgs e)
        {
            if (currentUser_ == null || currentUser_.Role != UserRole.Admin)
            {
                return;
            }

            Product product = (Product)productsListBox.SelectedItem;
            if (product == null)
            {
                return;
            }

            AddOrEditProductForm editForm = new AddOrEditProductForm(productService_, product, true);
            DialogResult result = editForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                productService_.EditProduct(editForm.Product);

                products_.Clear();
                products_ = productService_.GetAllProducts();
                FillProducts(products_);

                searchToolStripTextBox.Clear();
            }
        }

        private void deleteProductButton_Click(object sender, EventArgs e)
        {
            Product product = (Product)productsListBox.SelectedItem;
            if (product == null)
            {
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите удалить товар {product.Article}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            if (result == DialogResult.Yes)
            {
                if (!orderService_.CheckArticle(product))
                {
                    productService_.DeleteProduct(product);

                    products_.Clear();
                    products_ = productService_.GetAllProducts();
                    FillProducts(products_);

                    searchToolStripTextBox.Clear();
                }
                else
                {
                    MessageBox.Show(
                        "Данный товар заказан. Удалить невозможно.",
                        "Ошибка удаления товара",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void showOrdersButton_Click(object sender, EventArgs e)
        {
            OrdersForm ordersForm = new OrdersForm(currentUser_);
            ordersForm.Show();
        }
    }
}
