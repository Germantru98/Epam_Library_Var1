using Entities;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IReaderDao
    {
        IEnumerable<Reader> GetAllReaders();

        void Add(Reader reader);

        void Update(Reader reader);

        void Remove(int ID);
    }
}