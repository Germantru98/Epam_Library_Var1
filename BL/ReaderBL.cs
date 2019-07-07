using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System.Collections.Generic;

namespace BL
{
    public class ReaderBL : IReaderBL
    {
        private IReaderDao readerDao = new ReaderDao();

        public void Add(Reader reader)
        {
            readerDao.Add(reader);
        }

        public IEnumerable<Reader> GetAllReaders()
        {
            return readerDao.GetAllReaders();
        }

        public void Remove(int ID)
        {
            readerDao.Remove(ID);
        }

        public void Update(Reader reader)
        {
            readerDao.Update(reader);
        }

        public IEnumerable<ReaderDemo> GetAllUsers()
        {
            return readerDao.GetAllUsers();
        }
    }
}