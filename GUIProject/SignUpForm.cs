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
            if (PasswordTextBox.Text == ConfirmPassTextBox.Text)
            {
                Reader reader = new Reader(NameTextBox.Text, SurnameTextBox.Text, PhoneTextBox.Text, LoginTextBox.Text, PasswordTextBox.Text);
                readerBL.Add(reader);
                MessageBox.Show("Registration completed");
                Close();
            }
            else
            {
                MessageBox.Show(" Passwords do not match");
            }
        }
    }
}