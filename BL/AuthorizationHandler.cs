using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;
using System;

namespace BL
{
    public class AuthorizationHandler : IAuthorizationHandler
    {
        private IAuthorizationDao authorizationDao = new AuthorizationDao();

        public void SetNewPassword(Reader reader, string newPassword)
        {
            if (reader.Reader_ID <= 0)
            {
                throw new ArgumentException("Reader parametr -> Reader_ID is negative or zero");
            }
            else if (string.IsNullOrEmpty(newPassword))
            {
                throw new ArgumentException("Wrong parametr -> newPassword");
            }
            else
            {
                authorizationDao.SetNewPassword(reader, newPassword);
            }
        }

        public void SetNewLogin(Reader reader, string newLogin)
        {
            if (reader.Reader_ID <= 0)
            {
                throw new ArgumentException("Reader parametr -> Reader_ID is negative or zero");
            }
            else if (string.IsNullOrEmpty(newLogin))
            {
                throw new ArgumentException("Wrong parametr -> newLogin");
            }
            else
            {
                authorizationDao.SetNewLogin(reader, newLogin);
            }
        }

        public string GetLogin(Reader reader)
        {
            if (reader.Reader_ID > 0)
            {
                return authorizationDao.GetLogin(reader);
            }
            else
            {
                throw new ArgumentException("Reader parametr -> Reader_ID is negative or zero");
            }
        }

        public string GetPassword(Reader reader)
        {
            if (reader.Reader_ID > 0)
            {
                return authorizationDao.GetPassword(reader);
            }
            else
            {
                throw new ArgumentException("Reader parametr -> Reader_ID is negative or zero");
            }
        }

        public bool IsLoginExist(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentException("Wrong parametr ->login");
            }
            else
            {
                return authorizationDao.IsLoginExist(login);
            }
        }

        public string GetPasswordForLogin(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                throw new ArgumentException("Wrong parametr ->login");
            }
            else
            {
                return authorizationDao.GetPasswordForLogin(login);
            }
        }

        public bool isAuthorized(string login, string password)
        {
            if (!string.IsNullOrEmpty(password))
            {
                string realpassword = "";
                try
                {
                    realpassword = GetPasswordForLogin(login);
                }
                catch (ArgumentException)
                {
                    throw new ArgumentException("Wrong parametr ->login");
                }
                if (password == realpassword)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else throw new ArgumentException("Wrong parametr ->password");
        }
    }
}