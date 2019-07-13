using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class SignUpForm : Form
    {
        private IReaderBL readerBL = new ReaderBL();

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (!isAllFieldEmpty())
            {
                if (PasswordTextBox.Text == ConfirmPassTextBox.Text)
                {
                    if (PhoneTextBox.MaskCompleted)
                    {
                        Reader reader = new Reader(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text);
                        readerBL.Add(reader);
                        MessageBox.Show("Registration completed");
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Check phone number");
                    }
                }
                else
                {
                    MessageBox.Show(" Passwords do not match");
                }
            }
            else
            {
                MessageBox.Show("Fill in empty fields");
            }
        }

        private void NameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(NameTextBox.Text))
            {
                EmptyFieldError.SetError(NameTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        private void SurnameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(SurnameTextBox.Text))
            {
                EmptyFieldError.SetError(SurnameTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }




        private void LoginTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PhoneTextBox.Text))
            {
                EmptyFieldError.SetError(PhoneTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        

        private void ConfirmPassTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(ConfirmPassTextBox.Text))
            {
                EmptyFieldError.SetError(ConfirmPassTextBox, "This field cant be empty!");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }

        private bool isAllFieldEmpty()
        {
            bool isNameTextBoxEmpty = string.IsNullOrEmpty(NameTextBox.Text);
            bool isSurnameTextBoxEmpty = string.IsNullOrEmpty(SurnameTextBox.Text);
            bool isPhoneTextBoxEmpty = string.IsNullOrEmpty(PhoneTextBox.Text);
            bool isLoginTextBoxEmpty = string.IsNullOrEmpty(LoginTextBox.Text);
            bool isPasswordTextBoxEmpty = string.IsNullOrEmpty(PasswordTextBox.Text);
            bool isConfirmPassTextBoxEmpty = string.IsNullOrEmpty(ConfirmPassTextBox.Text);
            if (isNameTextBoxEmpty || isSurnameTextBoxEmpty || isPhoneTextBoxEmpty || isLoginTextBoxEmpty || isPasswordTextBoxEmpty || isConfirmPassTextBoxEmpty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PhoneTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!PhoneTextBox.MaskCompleted)
            {
                EmptyFieldError.SetError(PhoneTextBox, "Check phone number");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }
    }
}