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
            if (realpassword == OldPasswordTextBox.Text && NewPasswordTextBox.Text == ConfirmPassTextBox.Text)
            {
                authorization.SetNewPassword(_reader, NewPasswordTextBox.Text);
                MessageBox.Show($"Password succesfuly changed.");
                Close();
            }
        }
    }
}