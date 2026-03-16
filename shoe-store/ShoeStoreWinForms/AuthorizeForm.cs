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
            userService_ = new UserService();
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginComboBox.Text;
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

            User user = userService_.Login(login, password);
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

        private void loginAsGuestButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(null);
            mainForm.Show();
            Hide();
        }

        private void AuthorizeForm_Load(object sender, EventArgs e)
        {
            loginComboBox.DataSource = userService_.GetAllLogins();
        }
    }
}
