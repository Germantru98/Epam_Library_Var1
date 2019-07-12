using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class ChangeInformationForm : Form
    {
        private IReaderBL readerBL = new ReaderBL();
        private Reader _reader;
        private string Atribute;
        private IAuthorizationHandler authorization = new AuthorizationHandler();

        public ChangeInformationForm(Reader reader, string atribute)
        {
            InitializeComponent();
            _reader = reader;
            AtributeLable.Text = $"Enter new {atribute}";
            Atribute = atribute;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            bool check = true;
            if (String.IsNullOrEmpty(AtributeTextBox.Text))
            {
                MessageBox.Show("Enter some data!");
            }
            else
            {
                if (Atribute == "Name")
                {
                    _reader.Name = AtributeTextBox.Text;
                }
                if (Atribute == "Surname")
                {
                    _reader.Surname = AtributeTextBox.Text;
                }
                if (Atribute == "Login")
                {
                    if (authorization.IsLoginExist(AtributeTextBox.Text))
                    {
                        check = false;
                        MessageBox.Show("Login already exists");
                    }
                    else
                    {
                        authorization.SetNewLogin(_reader, AtributeTextBox.Text);
                    }
                }
                if (check)
                {
                    readerBL.Update(_reader);
                    MessageBox.Show($"{Atribute} changed." + Environment.NewLine + "Сhanges will be displayed after the next authorization.");
                    Close();
                }
            }
        }

        private void AtributeTextBox_Validated(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(AtributeTextBox.Text))
            {
                EmptyFieldError.SetError(AtributeTextBox, "This field cant be empty!");
            }
        }

        private void ChangeInformationForm_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(AtributeTextBox.Text))
            {
                EmptyFieldError.SetError(AtributeTextBox, "This field cant be empty!");
            }
        }
    }
}