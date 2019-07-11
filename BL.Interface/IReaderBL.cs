using Entities;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface IReaderBL
    {
        void Add(Reader reader);

        void Update(Reader reader);

        void Remove(int ID);

        IEnumerable<Reader> GetAllReaders();

        IEnumerable<ReaderDemo> GetAllUsers();

        Reader GetReaderByLogin(string login);
    }
}