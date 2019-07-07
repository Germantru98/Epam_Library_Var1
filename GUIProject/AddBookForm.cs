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
            bookBL.Add(book);
            MessageBox.Show("Book successfully added");
            Close();
        }
    }
}