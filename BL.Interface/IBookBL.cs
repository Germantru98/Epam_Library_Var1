using Entities;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface IBookBL
    {
        void Add(Book book);

        void Update(Book book);

        void Remove(int ID);

        IEnumerable<Book> GetAllBooks();

        IEnumerable<Book> GetBooksByTitle(string title);

        IEnumerable<Book> GetBooksByAuthor(string author);

        IEnumerable<UserLibraryBook> GetBooksByID(int Reader_ID);
    }
}