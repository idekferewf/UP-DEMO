using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ShoeStoreLib.Interfaces;
using ShoeStoreLib.Models;

namespace ShoeStoreLib.Repositories
{
    public class MySQLOrderRepository: IOrderRepository
    {
        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "SELECT o.id, o.order_date, o.delivery_date, p.address, o.user_fio, o.code, o.status " +
                                   "FROM orders o " +
                                   "LEFT JOIN pickup_locations p ON o.pickup_id = p.id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order(reader.GetInt32("id"));
                            order.OrderDate = reader.GetDateTime("order_date");
                            order.DeliveryDate = reader.GetDateTime("delivery_date");
                            //order.PickupLocationAddress = reader.GetString("address");
                            //order.UserFio = reader.GetString("user_fio");
                            order.Code = reader.GetInt32("code");
                            order.Status = reader.GetString("status");
                            orders.Add(order);
                        }
                    }
                }

                foreach (Order order in orders)
                {
                    order.Products = GetAllOrderProducts(order.Id);
                }

                return orders;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при получении заказов: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return orders;
            }
        }

        public List<OrderProductRecord> GetAllOrderProducts(int id)
        {
            List<OrderProductRecord> products = new List<OrderProductRecord>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "SELECT order_id, product_article, quantity FROM order_products WHERE order_id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OrderProductRecord record = new OrderProductRecord();
                            record.Article = reader.GetString("product_article");
                            record.Quantity = reader.GetInt32("quantity");
                            products.Add(record);
                        }
                    }
                }

                return products;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при получении товаров заказа: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return products;
            }
        }

        public void AddOrder(Order order)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "INSERT INTO orders (order_date, delivery_date, user_fio, code, status) " +
                                   "VALUES (@order_date, @delivery_date, @user_login, @code, @status)";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@order_date", order.OrderDate);
                    command.Parameters.AddWithValue("@delivery_date", order.DeliveryDate);
                    //command.Parameters.AddWithValue(s"@user_login", order.UserFio);
                    command.Parameters.AddWithValue("@code", order.Code);
                    command.Parameters.AddWithValue("@status", order.Status);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при добавлении заказа: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void EditOrder(Order order)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "UPDATE orders SET order_date = @order_date, delivery_date = @delivery_date, " +
                                   "user_fio = @user_fio, code = @code, status = @status WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);

                    command.Parameters.AddWithValue("@order_date", order.OrderDate);
                    command.Parameters.AddWithValue("@delivery_date", order.DeliveryDate);
                    //command.Parameters.AddWithValue("@user_fio", order.UserFio);
                    command.Parameters.AddWithValue("@code", order.Code);
                    command.Parameters.AddWithValue("@status", order.Status);
                    command.Parameters.AddWithValue("@id", order.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при редактировании заказа: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        public void DeleteOrder(Order order)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
                {
                    conn.Open();

                    string query = "DELETE FROM orders WHERE id = @id";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@id", order.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Ошибка при удалении заказа: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}
