using ShoeStoreLib;
using ShoeStoreLib.Models;
using System;
using System.Windows.Forms;

namespace ShoeStoreWinForms
{
    public partial class AuthorizeForm : Form
    {
        private UsersModel _usersModel = new UsersModel();

        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void authorizeButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            User user = _usersModel.Login(login, password);
            if (user != null)
            {
                MainForm mainForm = new MainForm();
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
