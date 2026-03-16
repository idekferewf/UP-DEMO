using System;
using System.Drawing;
using System.Windows.Forms;
using ShoeStoreLib;

namespace ShoeStoreWinForms
{
    public partial class ProductCard : UserControl
    {
        public ProductCard()
        {
            InitializeComponent();

            photoPictureBox.DoubleClick += ChildControl_DoubleClick;
            categoryLabel.DoubleClick += ChildControl_DoubleClick;
            quantityLabel.DoubleClick += ChildControl_DoubleClick;
            quantityNameLabel.DoubleClick += ChildControl_DoubleClick;
            descriptionLabel.DoubleClick += ChildControl_DoubleClick;
            discountLabel.DoubleClick += ChildControl_DoubleClick;
            label1.DoubleClick += ChildControl_DoubleClick;
            label2.DoubleClick += ChildControl_DoubleClick;
            label3.DoubleClick += ChildControl_DoubleClick;
            label4.DoubleClick += ChildControl_DoubleClick;
            label5.DoubleClick += ChildControl_DoubleClick;
            label6.DoubleClick += ChildControl_DoubleClick;
            producerLabel.DoubleClick += ChildControl_DoubleClick;
            nameLabel.DoubleClick += ChildControl_DoubleClick;
            newPriceLabel.DoubleClick += ChildControl_DoubleClick;
            priceLabel.DoubleClick += ChildControl_DoubleClick;
            supplierLabel.DoubleClick += ChildControl_DoubleClick;
            unitLabel.DoubleClick += ChildControl_DoubleClick;
        }

        public void ShowProductInfo(Product product)
        {
            categoryLabel.Text = product.Category;
            nameLabel.Text = product.Name;
            descriptionLabel.Text = product.Description;
            producerLabel.Text = product.Producer;
            supplierLabel.Text = product.Supplier;
            priceLabel.Text = product.Price.ToString();
            unitLabel.Text = product.Unit;
            quantityLabel.Text = product.Quantity.ToString();
            discountLabel.Text = product.Discount.ToString();

            if (!string.IsNullOrEmpty(product.PhotoPath))
            {
                photoPictureBox.Load($"Pictures/{product.PhotoPath}");
            }
            else
            {
                photoPictureBox.Load("Pictures/picture.png");
            }

            if (product.Discount > 15)
            {
                BackColor = ColorTranslator.FromHtml("#2E8B57");
            }
            else
            {
                BackColor = Color.FromName("Chartreuse");
            }

            if (product.Discount != 0)
            {
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Strikeout);
                priceLabel.ForeColor = Color.FromName("Red");

                newPriceLabel.Text = (product.Price - (product.Price / 100 * product.Discount)).ToString();
            }
            else
            {
                priceLabel.Font = new Font(priceLabel.Font, FontStyle.Regular);
                priceLabel.ForeColor = Color.FromName("ControlText");

                newPriceLabel.Text = "";
            }

            if (product.Quantity == 0)
            {
                quantityLabel.ForeColor = Color.FromName("DeepSkyBlue");
                quantityNameLabel.ForeColor = Color.FromName("DeepSkyBlue");
            }
            else
            {
                quantityLabel.ForeColor = Color.FromName("ControlText");
                quantityNameLabel.ForeColor = Color.FromName("ControlText");
            }
        }

        private void ChildControl_DoubleClick(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }
    }
}
