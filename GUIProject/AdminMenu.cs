using BL;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class AdminMenu : Form
    {
        private BookBL bookBL = new BookBL();
        private ReaderBL readerBL = new ReaderBL();

        public AdminMenu()
        {
            InitializeComponent();
            LibraryTable.DataSource = bookBL.GetAllBooks();
            UsersTable.DataSource = readerBL.GetAllUsers();
        }

        private void AddBookButton_Click(object sender, System.EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            form.Show();
        }

        private void RefreshButton_Click(object sender, System.EventArgs e)
        {
            LibraryTable.DataSource = bookBL.GetAllBooks();
        }

        private void RemoveBookButton_Click(object sender, System.EventArgs e)
        {
            int selectedBookID = (int)LibraryTable.CurrentRow.Cells[0].Value;
            bookBL.Remove(selectedBookID);
        }
    }
}