using BL.Interface;
using DAL;
using Entities;
using System.Collections.Generic;

namespace BL
{
    public class BookBL : IBookBL
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

        public IEnumerable<Book> GetBooksByTitle(string title)
        {
            return bookDao.GetBooksByTitle(title);
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return bookDao.GetBooksByAuthor(author);
        }
    }
}