using ShoeStoreLib;
using ShoeStoreLib.Models;
using System;
using System.Windows.Forms;

namespace ShoeStoreWinForms
{
    public partial class AuthorizeForm : Form
    {
        private UserService userService_;

        public AuthorizeForm()
        {
            // Создание объекта сервиса пользователей
            userService_ = new UserService(new MySQLUserRepository());

            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            // Проверка, введён ли пароль
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Пожалуйста, введите пароль.",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            // Получение пользователя по логину и паролю (авторизация)
            User user = userService_.Login(login, password);
            if (user != null)
            {
                // Открытие основной формы
                MainForm mainForm = new MainForm(user);
                mainForm.FormClosed += (s, args) => Close();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show(
                    "Неверный пароль. Пожалуйста, повторите попытку.",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void loginAsGuestButton_Click(object sender, EventArgs e)
        {
            // Открытие основной формы под гостем
            MainForm mainForm = new MainForm(null);
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
            Hide();
        }
    }
}
