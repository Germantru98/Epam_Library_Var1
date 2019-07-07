using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System.Collections.Generic;

namespace BL
{
    public class BookBL : IBookBL
    {
        private IBookDao bookDao = new BookDao();

        public void Add(Book book)
        {
            bookDao.Add(book);
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

        public IEnumerable<Book> GetAllBooks()
        {
            return bookDao.GetAllBooks();
        }

        public IEnumerable<UserLibraryBook> GetBooksByID(int Reader_ID)
        {
            return bookDao.GetBooksByID(Reader_ID);
        }
    }
}