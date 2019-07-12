using Entities;

namespace DAL.Interface
{
    public interface IAuthorizationDao
    {
        string GetLogin(Reader reader);

        string GetPassword(Reader reader);

        void SetNewPassword(Reader reader, string newPassword);

        void SetNewLogin(Reader reader, string newLogin);

        bool IsLoginExist(string login);

        bool IsPhoneExist(string phone);

        string GetPasswordForLogin(string login);
    }
}