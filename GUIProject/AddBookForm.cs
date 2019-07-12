using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class AddBookForm : Form
    {
        private IBookBL bookBL = new BookBL();

        public AddBookForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Book book = new Book(TitleTextBox.Text, AuthorTextBox.Text, dateTimePicker1.Value);
            try
            {
                bookBL.Add(book);
                MessageBox.Show("Book successfully added");
                Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Fill in empty fields");
            }
        }

        private void TitleTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TitleTextBox.Text))
            {
                EmptyFieldError.SetError(TitleTextBox, "This field cant be empty");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }

        private void AuthorTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(AuthorTextBox.Text))
            {
                EmptyFieldError.SetError(AuthorTextBox, "This field cant be empty");
            }
            else
            {
                EmptyFieldError.Clear();
            }
        }
    }
}