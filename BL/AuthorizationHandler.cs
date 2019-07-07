using BL.Interface;
using DAL;
using DAL.Interface;
using Entities;

namespace BL
{
    public class AuthorizationHandler : IAuthorizationHandler
    {
        private IAuthorizationDao authorizationDao = new AuthorizationDao();

        public void SetNewPassword(Reader reader, string newPassword)
        {
            authorizationDao.SetNewPassword(reader, newPassword);
        }

        public void SetNewLogin(Reader reader, string newLogin)
        {
            authorizationDao.SetNewLogin(reader, newLogin);
        }

        public string GetLogin(Reader reader)
        {
            return authorizationDao.GetLogin(reader);
        }

        public string GetPassword(Reader reader)
        {
            return authorizationDao.GetPassword(reader);
        }

        public bool IsLoginExist(string login)
        {
            return authorizationDao.IsLoginExist(login);
        }

        public string GetPasswordForLogin(string login)
        {
            return authorizationDao.GetPasswordForLogin(login);
        }

        public bool isAuthorized(string login, string password)
        {
            string realpassword = GetPasswordForLogin(login);
            if (password == realpassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Reader GetReaderByLogin(string login)
        {
            return authorizationDao.GetReaderByLogin(login);
        }
    }
}