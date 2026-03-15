using ShoeStoreLib;
using ShoeStoreLib.Models;
using System;
using System.Windows.Forms;

namespace ShoeStoreWinForms
{
    public partial class AuthorizeForm : Form
    {
        private UserService usersService_ = new UserService();

        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Пожалуйста, введите пароль",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            User user = usersService_.Login(login, password);
            if (user != null)
            {
                MainForm mainForm = new MainForm(user);
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
    }
}
