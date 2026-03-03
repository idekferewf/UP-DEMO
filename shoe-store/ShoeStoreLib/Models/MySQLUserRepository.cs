using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ShoeStoreLib.Models
{
    public class MySQLUserRepository : IUsersRepository
    {
        private string connectionString = "server=127.0.0.1;uid=root;pwd=vertrigo;database=shoe_store;";

        public User GetUserByLogin(string login)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, role, fio, login, password FROM users WHERE login = @login;";

                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.Parameters.AddWithValue("@login", login);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            User user = new User(reader.GetInt32("id"));

                            user.Fio = reader.GetString("fio");
                            user.Login = reader.GetString("login");
                            user.Password = reader.GetString("password");

                            string role = reader.GetString("role");
                            if (role == "Администратор")
                            {
                                user.Role = UserRole.Admin;
                            }
                            else if (role == "Менеджер")
                            {
                                user.Role = UserRole.Manager;
                            }
                            else
                            {
                                user.Role = UserRole.Client;
                            }

                            return user;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при получении пользователя: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            return null;
        }
    }
}
