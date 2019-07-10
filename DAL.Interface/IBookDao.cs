using Entities;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IBookDao
    {
        void Add(Book book);

        void Update(Book book);

        void Remove(int ID);

        IEnumerable<Book> GetAllBooks();

        IEnumerable<Book> GetBooksByTitle(string title);

        IEnumerable<Book> GetBooksByAuthor(string author);

        IEnumerable<UserBook> GetBooksByID(int Reader_ID);
    }
}