using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ShoeStoreLib.Interfaces;

namespace ShoeStoreLib.Repositories
{
    public class MySQLProductRepository: IProductRepository
    {
        public List<Product> GetAllProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "SELECT article, name, unit, price, supplier, producer, category, " +
                                   "discount, quantity, description, photo_path FROM products";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Product product = new Product(reader.GetString("article"));
                            product.Name = reader.GetString("name");
                            product.Unit = reader.GetString("unit");
                            product.Price = reader.GetDecimal("price");
                            product.Supplier = reader.GetString("supplier");
                            product.Producer = reader.GetString("producer");
                            product.Category = reader.GetString("category");
                            product.Discount = reader.GetInt32("discount");
                            product.Quantity = reader.GetInt32("quantity");
                            product.Description = reader.GetString("description");
                            product.PhotoPath = reader.IsDBNull(10) ? null : reader.GetString("photo_path");
                            products.Add(product);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при получении товаров: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return products;
        }

        public void AddProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "INSERT INTO products (article, name, unit, price, supplier, producer, category, discount, quantity, description, photo_path) " +
                                   "VALUES (@article, @name, @unit, @price, @supplier, @producer, @category, @discount, @quantity, @description, @photo_path)";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@article", product.Article);
                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@unit", product.Unit);
                    command.Parameters.AddWithValue("@price", product.Price);
                    command.Parameters.AddWithValue("@supplier", product.Supplier);
                    command.Parameters.AddWithValue("@producer", product.Producer);
                    command.Parameters.AddWithValue("@category", product.Category);
                    command.Parameters.AddWithValue("@discount", product.Discount);
                    command.Parameters.AddWithValue("@quantity", product.Quantity);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@photo_path", product.PhotoPath);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при добавлении товара: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void EditProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "UPDATE products SET name = @name, unit = @unit, price = @price, supplier = @supplier, " +
                                   "producer = @producer, category = @category, discount = @discount, quantity = @quantity, " +
                                   "description = @description, photo_path = @photo_path WHERE article = @article";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@name", product.Name);
                    command.Parameters.AddWithValue("@unit", product.Unit);
                    command.Parameters.AddWithValue("@price", product.Price);
                    command.Parameters.AddWithValue("@supplier", product.Supplier);
                    command.Parameters.AddWithValue("@producer", product.Producer);
                    command.Parameters.AddWithValue("@category", product.Category);
                    command.Parameters.AddWithValue("@discount", product.Discount);
                    command.Parameters.AddWithValue("@quantity", product.Quantity);
                    command.Parameters.AddWithValue("@description", product.Description);
                    command.Parameters.AddWithValue("@photo_path", product.PhotoPath);
                    command.Parameters.AddWithValue("@article", product.Article);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при редактировании товара: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void DeleteProduct(Product product)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "DELETE FROM products WHERE article = @article";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@article", product.Article);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при удалении товара: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
