using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using BL;

namespace GUIProject
{
    public partial class AddBookForm : Form
    {
        private BookBL bookBL = new BookBL();
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
