using Entities;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IReaderDao
    {
        void Add(Reader reader);

        void Update(Reader reader);

        void Remove(int ID);

        IEnumerable<Reader> GetAllReaders();

        IEnumerable<ReaderDemo> GetAllUsers();
    }
}