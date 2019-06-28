using Entities;
using System.Collections.Generic;

namespace BL.Interface
{
    public interface IReaderBL
    {
        IEnumerable<Reader> GetAllReaders();

        void Add(Reader reader);

        void Update(Reader reader);

        void Remove(int ID);
    }
}