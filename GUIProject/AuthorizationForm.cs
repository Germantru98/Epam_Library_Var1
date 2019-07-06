using BL;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class AuthorizationForm : Form
    {
        private AuthorizationHandler authorization = new AuthorizationHandler();
        private Reader _reader;

        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpForm form = new SignUpForm();
            form.Show();
        }

        private void ForgotPasswordLable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ForgotPasswordForm form = new ForgotPasswordForm();
            form.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "Admin" && PasswordTextBox.Text == "admin")
            {
                Hide();
                AdminMenu menu = new AdminMenu();
                menu.Show();
            }
            else
            {
                if (authorization.isAuthorized(LoginTextBox.Text, PasswordTextBox.Text))
                {
                    Hide();
                    _reader = authorization.GetReaderByLogin(LoginTextBox.Text);
                    UserForm form = new UserForm(_reader);
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Error, wrong data");
                    Show();
                }
            }
        }
    }
}