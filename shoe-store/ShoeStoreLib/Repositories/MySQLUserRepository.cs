using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace ShoeStoreLib.Models
{
    public class MySQLUserRepository : IUserRepository
    {
        public User GetUserByLogin(string login)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DbConfig.CONNECTION_STRING))
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
                MessageBox.Show(
                    $"Ошибка при получении пользователя: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return null;
        }
    }
}
