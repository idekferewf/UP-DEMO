using ShoeStoreLib.Services;
using ShoeStoreLib;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ShoeStoreWinForms
{
    public partial class AddOrEditForm : Form
    {
        private string selectedImagePath_ = "Pictures/picture.png";
        private Product product_;
        private ProductService productService_;
        private bool isEdit_;

        public AddOrEditForm(ProductService service, Product product, bool isEdit)
        {
            product_ = product;
            productService_ = service;
            isEdit_ = isEdit;
            InitializeComponent();
        }

        public Product Product => product_;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(articleTextBox.Text))
            {
                MessageBox.Show(
                    "Поле «Артикул» не может быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                articleTextBox.Focus();
                return;
            }

            if (!isEdit_ && HasArticle(articleTextBox.Text))
            {
                MessageBox.Show(
                    "Товар с указанным артикулом уже существует.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                articleTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show(
                    "Поле «Название» не может быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                nameTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(unitTextBox.Text))
            {
                MessageBox.Show(
                    "Поле «Единица измерения» не может быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                unitTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(supplierTextBox.Text))
            {
                MessageBox.Show(
                    "Поле «Поставщик» не может быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                supplierTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(producerTextBox.Text))
            {
                MessageBox.Show(
                    "Поле «Производитель» не может быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                producerTextBox.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show(
                    "Поле «Описание» не может быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                descriptionTextBox.Focus();
                return;
            }

            if (!isEdit_)
            {
                product_ = new Product(articleTextBox.Text);
            }

            product_.Name = nameTextBox.Text;
            product_.Unit = unitTextBox.Text;
            product_.Price = priceNumericUpDown.Value;
            product_.Supplier = supplierTextBox.Text;
            product_.Producer = producerTextBox.Text;
            product_.Category = categoryComboBox.Text;
            product_.Discount = (int)discountNumericUpDown.Value;
            product_.Quantity = (int)quantityNumericUpDown.Value;
            product_.Description = descriptionTextBox.Text;
            product_.PhotoPath = selectedImagePath_;
            DialogResult = DialogResult.OK;
        }

        public bool HasArticle(string article)
        {
            return productService_.GetAllProducts().Any(p => p.Article == article);
        }

        private void AddOrEditForm_Load(object sender, EventArgs e)
        {
            if (!isEdit_)
            {
                photoPictureBox.Load(selectedImagePath_);
                Text = "Добавление товара – ShoeStore";
                categoryComboBox.Text = "Мужская обувь";
            }
            else
            {
                Text = "Редактирование товара – ShoeStore";
                selectedImagePath_ = $"Pictures/{product_.PhotoPath}";
                photoPictureBox.Load(selectedImagePath_);
                articleTextBox.Text = product_.Article;
                articleTextBox.Enabled = false;
                nameTextBox.Text = product_.Name;
                unitTextBox.Text = product_.Unit;
                priceNumericUpDown.Value = product_.Price;
                supplierTextBox.Text = product_.Supplier;
                producerTextBox.Text = product_.Producer;
                categoryComboBox.Text = product_.Category;
                discountNumericUpDown.Value = product_.Discount;
                quantityNumericUpDown.Value = product_.Quantity;
                descriptionTextBox.Text = product_.Description;
            }
        }

        private void loadPhotoButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif|All Files|*.*";
                openFileDialog.Title = "Выберите изображение для товара";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourcePath = openFileDialog.FileName;
                        string fileName = Path.GetFileName(sourcePath);
                        string targetPath = Path.Combine(Application.StartupPath, fileName);
                        File.Copy(sourcePath, targetPath, true);

                        selectedImagePath_ = fileName;

                        photoPictureBox.Image?.Dispose();
                        photoPictureBox.Image = Image.FromFile(targetPath);
                        photoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                        MessageBox.Show(
                            "Изображение успешно загружено!",
                            "Успех",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(
                            $"Ошибка при загрузке изображения: {ex.Message}",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error
                        );
                    }
                }
            }
        }
    }
}
