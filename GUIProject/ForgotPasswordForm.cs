using BL;
using BL.Interface;
using Entities;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class ForgotPasswordForm : Form
    {
        private IAuthorizationHandler authorization = new AuthorizationHandler();
        private IReaderBL readerBL = new ReaderBL();

        public ForgotPasswordForm()
        {
            InitializeComponent();
        }

        private void LoginTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(LoginTextBox.Text))
            {
                ErrorIcon.SetError(LoginTextBox, "This field cant be empty!");
            }
            else if (!authorization.IsLoginExist(LoginTextBox.Text))
            {
                ErrorIcon.SetError(LoginTextBox, "Login is not exists");
            }
            else
            {
                ErrorIcon.Clear();
            }
        }

        private void PhoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!PhoneTextBox.MaskCompleted)
            {
                ErrorIcon.SetError(PhoneTextBox, "Wrong phone number");
            }
            else if (!authorization.IsPhoneExist(PhoneTextBox.Text))
            {
                ErrorIcon.SetError(PhoneTextBox, "Phone is not exists");
            }
            else
            {
                ErrorIcon.Clear();
            }
        }

        private void NewPasswordTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(NewPasswordTextBox.Text))
            {
                ErrorIcon.SetError(NewPasswordTextBox, "This field cant be empty!");
            }
            else
            {
                ErrorIcon.Clear();
            }
        }

        private void ConfirmPassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(ConfirmPassTextBox.Text))
            {
                ErrorIcon.SetError(ConfirmPassTextBox, "This field cant be empty!");
            }
            else if (NewPasswordTextBox.Text != ConfirmPassTextBox.Text)
            {
                ErrorIcon.SetError(ConfirmPassTextBox, "Passwords do not match");
            }
            else
            {
                ErrorIcon.Clear();
            }
        }

        private void ForgotPasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }

        private void AcceptButton_Click(object sender, System.EventArgs e)
        {
            if (isFieldsCorrect())
            {
                if (PhoneTextBox.MaskCompleted)
                {
                    Reader reader = readerBL.GetReaderByLogin(LoginTextBox.Text);
                    if (reader.Phone == PhoneTextBox.Text)
                    {
                        if (NewPasswordTextBox.Text == ConfirmPassTextBox.Text)
                        {
                            authorization.SetNewPassword(reader, NewPasswordTextBox.Text);
                            MessageBox.Show("Password changed, try to sign in");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Passwords do not match");
                        }
                    }
                    else
                    {
                        MessageBox.Show("User with this login has a different phone number");
                    }
                }
                else
                {
                    MessageBox.Show("Wrong phone number");
                }
            }
            else
            {
                MessageBox.Show("Fill in empty fields");
            }
        }

        private bool isFieldsCorrect()
        {
            bool isLogin = string.IsNullOrEmpty(LoginTextBox.Text);
            bool isPhone = string.IsNullOrEmpty(PhoneTextBox.Text);
            bool isNewPass = string.IsNullOrEmpty(NewPasswordTextBox.Text);
            bool isConfirmPass = string.IsNullOrEmpty(ConfirmPassTextBox.Text);
            if (isLogin || isPhone || isNewPass || isConfirmPass)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}