using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System;
using System.Collections.Generic;

namespace BL
{
    public class BookBL : IBookBL
    {
        private IBookDao bookDao = new BookDao();

        public void Add(Book book)
        {
            if (book.isCorrectState())
            {
                bookDao.Add(book);
            }
            else
            {
                throw new ArgumentException("Error, Added book in incorrec state (empty fields)");
            }
            
        }

        public void Remove(int ID)
        {
            if (ID > 0)
            {
                bookDao.Remove(ID);
            }
            else
            {
                throw new ArgumentException("ID is negative or zero");
            }
            
        }

        public void Update(Book book)
        {
            if (book.isCorrectState())
            {
                bookDao.Update(book);
            }
            else
            {
                throw new ArgumentException("Error, updated book in incorrec state (empty fields)");
            }
            
        }

        public IEnumerable<Book> GetBooksByTitle(string title)
        {
            if (!string.IsNullOrEmpty(title))
            {
                return bookDao.GetBooksByTitle(title);
            }
            else
            {
                throw new ArgumentException("Value empty or null -> title");
            }
            
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            if (!string.IsNullOrEmpty(author))
            {
                return bookDao.GetBooksByAuthor(author);
            }
            else
            {
                throw new ArgumentException("Value empty or null -> author");
            }
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return bookDao.GetAllBooks();
        }

        public IEnumerable<UserBook> GetBooksByID(int Reader_ID)
        {
            if (Reader_ID > 0)
            {
                return bookDao.GetBooksByID(Reader_ID);
            }
            else
            {
                throw new ArgumentException("Reader_ID is negative or zero");
            }
            
        }
    }
}