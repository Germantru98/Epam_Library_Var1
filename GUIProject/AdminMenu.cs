using BL;
using BL.Interface;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class AdminMenu : Form
    {
        private IBookBL bookBL = new BookBL();
        private IReaderBL readerBL = new ReaderBL();

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
            MessageBox.Show($"Book № {selectedBookID} succesfully removed from database");
        }

        private void AdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }
    }
}