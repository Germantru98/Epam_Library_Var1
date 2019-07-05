using BL;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class AuthorizationForm : Form
    {
        private AuthorizationHandler authorization = new AuthorizationHandler();

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
            if (authorization.isAuthorized(LoginTextBox.Text, PasswordTextBox.Text))
            {
                UserForm form = new UserForm();
                form.Show();
            }
        }
    }
}