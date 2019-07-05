using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using Entities;

namespace GUIProject
{
    public partial class UserForm : Form
    {
        private BookBL bookBL = new BookBL();
        private Reader _reader;

        public UserForm(Reader reader)
        {
            InitializeComponent();
            BooksDGV.DataSource = bookBL.GetAllBooks();
            _reader = reader;
        }

        private void AddToUserLibraryButton_Click(object sender, EventArgs e)
        {
        }
    }
}