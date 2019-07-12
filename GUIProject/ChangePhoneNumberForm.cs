using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class ChangePhoneNumberForm : Form
    {
        private Reader _reader;
        private IReaderBL readerBL = new ReaderBL();

        public ChangePhoneNumberForm(Reader reader)
        {
            _reader = reader;
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PhoneTextBox.Text))
            {
                MessageBox.Show("Fill in new phone number");
            }
            else
            {
                _reader.Phone = PhoneTextBox.Text;
                readerBL.Update(_reader);
                MessageBox.Show("Number succesfully changed");
                Close();
            }
        }
    }
}