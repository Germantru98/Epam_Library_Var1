using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class AuthorizationForm : Form
    {
        private IAuthorizationHandler authorization = new AuthorizationHandler();
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
            if (!isFieldsEmpty())
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
                        MessageBox.Show("Error, wrong data" + Environment.NewLine + "Check Login or Password");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fill in empty fields");
            }
        }

        private void AuthorizationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void LoginTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(LoginTextBox.Text))
            {
                EmptyFieldError.SetError(LoginTextBox, "This field cant be empty!");
            }
            else if (!authorization.IsLoginExist(LoginTextBox.Text))
            {
                EmptyFieldError.SetError(LoginTextBox, "Login is not exists");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        private void PasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PasswordTextBox.Text))
            {
                EmptyFieldError.SetError(PasswordTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        private bool isFieldsEmpty()
        {
            bool isLoginTextBoxEmpty = string.IsNullOrEmpty(LoginTextBox.Text);
            bool isPasswordTextBoxEmpty = string.IsNullOrEmpty(PasswordTextBox.Text);
            if (isLoginTextBoxEmpty || isPasswordTextBoxEmpty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}