using BL;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class ChangeInformationForm : Form
    {
        private ReaderBL readerBL = new ReaderBL();
        private Reader _reader;
        private string Atribute;
        private AuthorizationHandler authorization = new AuthorizationHandler();

        public ChangeInformationForm(Reader reader, string atribute)
        {
            InitializeComponent();
            _reader = reader;
            AtributeLable.Text = $"Enter new {atribute}";
            Atribute = atribute;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (Atribute == "Name")
            {
                _reader.Name = AtributeTextBox.Text;
            }
            if (Atribute == "Surname")
            {
                _reader.Surname = AtributeTextBox.Text;
            }
            if (Atribute == "Phone")
            {
                _reader.Phone = AtributeTextBox.Text;
            }
            if (Atribute == "Login")
            {
                authorization.SetNewLogin(_reader, AtributeTextBox.Text);
            }
            readerBL.Update(_reader);
            MessageBox.Show($"{Atribute} changed." + Environment.NewLine + "Сhanges will be displayed after the next authorization.");
            Close();
        }
    }
}