using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System.Collections.Generic;
using System;

namespace BL
{
    public class ReaderBL : IReaderBL
    {
        private IReaderDao readerDao = new ReaderDao();

        public void Add(Reader reader)
        {
            if (reader.isCorrectState())
            {
                readerDao.Add(reader);
            }
            else
            {
                throw new ArgumentException("Error, Added reader in incorrec state (empty fields)");
            }
            
        }

        public IEnumerable<Reader> GetAllReaders()
        {
            return readerDao.GetAllReaders();
        }

        public void Remove(int ID)
        {
            if (ID > 0)
            {
                readerDao.Remove(ID);
            }
            else
            {
                throw new ArgumentException("ID is negative or zero");
            }
        }

        public void Update(Reader reader)
        {
            if (reader.isCorrectState())
            {
                readerDao.Update(reader);
            }
            else
            {
                throw new ArgumentException("Error, updated reader in incorrec state (empty fields)");
            }
        }

        public IEnumerable<ReaderDemo> GetAllUsers()
        {
            return readerDao.GetAllUsers();
        }

        public Reader GetReaderByLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentException("Value empty or null -> login");
            }
            else
            {
                return readerDao.GetReaderByLogin(login);
            }
        }
    }
}