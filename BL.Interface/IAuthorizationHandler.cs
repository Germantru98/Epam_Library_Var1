using Entities;

namespace BL.Interface
{
    public interface IAuthorizationHandler
    {
        string GetLogin(Reader reader);

        string GetPassword(Reader reader);

        void SetNewPassword(Reader reader, string newPassword);

        void SetNewLogin(Reader reader, string newLogin);

        bool IsLoginExist(string login);

        string GetPasswordForLogin(string login);

        bool isAuthorized(string login, string password);
    }
}