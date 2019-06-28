using BL.Interface;
using DAL;
using Entities;
using System.Collections.Generic;

namespace BL
{
    internal class BookBL : IBookBL
    {
        private BookDao bookDao = new BookDao();

        public void Add(Book book)
        {
            bookDao.Add(book);
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookDao.GetAllBooks();
        }

        public void Remove(int ID)
        {
            bookDao.Remove(ID);
        }

        public void Update(Book book)
        {
            bookDao.Update(book);
        }
    }
}