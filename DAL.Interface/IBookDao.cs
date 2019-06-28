using Entities;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IBookDao
    {
        IEnumerable<Book> GetAllBooks();

        void Add(Book book);

        void Update(Book book);

        void Remove(int ID);
    }
}