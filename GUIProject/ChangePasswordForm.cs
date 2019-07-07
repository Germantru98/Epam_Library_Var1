using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class ChangePasswordForm : Form
    {
        private IAuthorizationHandler authorization = new AuthorizationHandler();
        private Reader _reader;

        public ChangePasswordForm(Reader reader)
        {
            InitializeComponent();
            _reader = reader;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            string realpassword = authorization.GetPasswordForLogin(_reader.Login);
            if (!string.IsNullOrEmpty(ConfirmPassTextBox.Text) && !string.IsNullOrEmpty(NewPasswordTextBox.Text) && !string.IsNullOrEmpty(OldPasswordTextBox.Text))
            {
                if (realpassword == OldPasswordTextBox.Text && NewPasswordTextBox.Text == ConfirmPassTextBox.Text)
                {
                    authorization.SetNewPassword(_reader, NewPasswordTextBox.Text);
                    MessageBox.Show($"Password succesfuly changed.");
                    Close();
                }
                else if (realpassword != OldPasswordTextBox.Text)
                {
                    MessageBox.Show("Wrong old password");
                }
                else if (NewPasswordTextBox.Text != ConfirmPassTextBox.Text)
                {
                    MessageBox.Show("Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Enter empty field");
            }
        }

        private void ConfirmPassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ConfirmPassTextBox.Text))
            {
                EmptyFieldError.SetError(ConfirmPassTextBox, "This field cant be empty!");
            }
            else if (NewPasswordTextBox.Text != ConfirmPassTextBox.Text)
            {
                WrongConfirmPassError.SetError(ConfirmPassTextBox, "Password does not match new");
            }
            else
            {
                WrongConfirmPassError.Clear();
            }
        }

        private void NewPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(NewPasswordTextBox.Text))
            {
                EmptyFieldError.SetError(NewPasswordTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        private void OldPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(OldPasswordTextBox.Text))
            {
                EmptyFieldError.SetError(OldPasswordTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }
    }
}