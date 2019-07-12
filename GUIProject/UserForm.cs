using BL;
using BL.Interface;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class UserForm : Form
    {
        private IBookBL bookBL = new BookBL();
        private Reader _reader;
        private ITicketBL ticketBL = new TicketBL();

        public UserForm(Reader reader)
        {
            InitializeComponent();
            BooksDGV.DataSource = bookBL.GetAllBooks();
            _reader = reader;
            LoginInf.Text = _reader.Login;
            NameInf.Text = _reader.Name;
            SurnameInf.Text = _reader.Surname;
            PhoneInf.Text = _reader.Phone;
            MyLibraryTable.DataSource = bookBL.GetBooksByID(_reader.Reader_ID);
        }

        private void AddToUserLibraryButton_Click(object sender, EventArgs e)
        {
            int selectedBookID = (int)BooksDGV.CurrentRow.Cells[0].Value;
            Ticket tmpTicket = new Ticket(_reader.Reader_ID, selectedBookID, DateTime.Now, DateTime.Now + new TimeSpan(7, 00, 00, 00));
            ticketBL.Add(tmpTicket);
            MessageBox.Show("Book successfully added");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedBookID = (int)MyLibraryTable.CurrentRow.Cells[0].Value;
            ticketBL.Remove(selectedBookID);
            MessageBox.Show($"Book № {selectedBookID} succesfully removed from your library");
        }

        private void ExtendBookButton_Click(object sender, EventArgs e)
        {
            int selectedTicketID = (int)MyLibraryTable.CurrentRow.Cells[0].Value;
            Ticket tmp = ticketBL.GetTicketByID(selectedTicketID);
            tmp.EndDate += new TimeSpan(7, 00, 00, 00);
            ticketBL.Update(tmp);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            MyLibraryTable.DataSource = bookBL.GetBooksByID(_reader.Reader_ID);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (AuthorRButton.Checked && ParamTextBox.Text != null)
            {
                BooksDGV.DataSource = bookBL.GetBooksByAuthor(ParamTextBox.Text);
            }
            else if (TitleRButton.Checked && ParamTextBox.Text != null)
            {
                BooksDGV.DataSource = bookBL.GetBooksByTitle(ParamTextBox.Text);
            }
            else
            {
                BooksDGV.DataSource = bookBL.GetAllBooks();
            }
        }

        private void RefreshButton1_Click(object sender, EventArgs e)
        {
            BooksDGV.DataSource = bookBL.GetAllBooks();
        }

        private void ChangeNameButton_Click(object sender, EventArgs e)
        {
            ChangeInformationForm form = new ChangeInformationForm(_reader, "Name");
            form.Show();
        }

        private void ChangeSurnameButton_Click(object sender, EventArgs e)
        {
            ChangeInformationForm form = new ChangeInformationForm(_reader, "Surname");
            form.Show();
        }

        private void ChangePhoneButton_Click(object sender, EventArgs e)
        {
            ChangePhoneNumberForm form = new ChangePhoneNumberForm(_reader);
            form.Show();
        }

        private void ChangeLoginButton_Click(object sender, EventArgs e)
        {
            ChangeInformationForm form = new ChangeInformationForm(_reader, "Login");
            form.Show();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePasswordForm form = new ChangePasswordForm(_reader);
            form.Show();
        }

        private void UserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AuthorizationForm form = new AuthorizationForm();
            form.Show();
        }
    }
}