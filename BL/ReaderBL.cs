using BL.Interface;
using DAL;
using Entities;
using System.Collections.Generic;

namespace BL
{
    public class ReaderBL : IReaderBL
    {
        private ReaderDao readerDao = new ReaderDao();

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

        public void SetNewPassword(Reader reader, string newPassword)
        {
            readerDao.SetNewPassword(reader, newPassword);
        }

        public void SetNewLogin(Reader reader, string newLogin)
        {
            readerDao.SetNewLogin(reader, newLogin);
        }

        public string GetLogin(Reader reader)
        {
            return readerDao.GetLogin(reader);
        }

        public string GetPassword(Reader reader)
        {
            return readerDao.GetPassword(reader);
        }

        public bool IsLoginExist(string login)
        {
            return readerDao.IsLoginExist(login);
        }

        public string GetPasswordForLogin(string login)
        {
            return readerDao.GetPasswordForLogin(login);
        }
    }
}