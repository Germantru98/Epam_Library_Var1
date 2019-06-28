using Entities;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface IBookBL
    {
        IEnumerable<Book> GetAllBooks();

        void Add(Book book);

        void Update(Book book);

        void Remove(int ID);
    }
}