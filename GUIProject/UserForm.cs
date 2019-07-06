﻿using BL;
using Entities;
using System;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class UserForm : Form
    {
        private BookBL bookBL = new BookBL();
        private Reader _reader;
        private TicketBL ticketBL = new TicketBL();
        private UserLibraryBL userLibrary = new UserLibraryBL();

        public UserForm(Reader reader)
        {
            InitializeComponent();
            BooksDGV.DataSource = bookBL.GetAllBooks();
            _reader = reader;
            LoginInf.Text = _reader.Login;
            NameInf.Text = _reader.Name;
            SurnameInf.Text = _reader.Surname;
            PhoneInf.Text = _reader.Phone;
            MyLibraryTable.DataSource = userLibrary.GetBooksByID(_reader.Reader_ID);
        }

        private void AddToUserLibraryButton_Click(object sender, EventArgs e)
        {
            int selectedBookID = (int)BooksDGV.CurrentRow.Cells[0].Value;
            Ticket tmpTicket = new Ticket(_reader.Reader_ID, selectedBookID, DateTime.Now, DateTime.Now + new TimeSpan(7, 00, 00, 00));
            ticketBL.Add(tmpTicket);
            MessageBox.Show("Книга успешно добавлена в вашу библиотеку");
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int selectedBookID = (int)MyLibraryTable.CurrentRow.Cells[0].Value;
            ticketBL.Remove(selectedBookID);
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
            MyLibraryTable.DataSource = userLibrary.GetBooksByID(_reader.Reader_ID);
        }
    }
}