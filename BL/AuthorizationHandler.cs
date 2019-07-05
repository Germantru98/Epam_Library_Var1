using DAL;
using Entities;

namespace BL
{
    public class AuthorizationHandler
    {
        private AuthorizationDao authorizationDao = new AuthorizationDao();

        public void SetNewPassword(Reader reader, string newPassword)
        {
            authorizationDao.SetNewPassword(reader, newPassword);
        }

        public void SetNewLogin(Reader reader, string newLogin)
        {
            authorizationDao.SetNewLogin(reader, newLogin);
        }

        private string GetLogin(Reader reader)
        {
            return authorizationDao.GetLogin(reader);
        }

        private string GetPassword(Reader reader)
        {
            return authorizationDao.GetPassword(reader);
        }

        private bool IsLoginExist(string login)
        {
            return authorizationDao.IsLoginExist(login);
        }

        private string GetPasswordForLogin(string login)
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
    }
}