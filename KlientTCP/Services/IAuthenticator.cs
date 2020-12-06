namespace KlientTCP.Services
{
    public interface IAuthenticator
    {
        bool IsLoggedIn { get; }

        bool Login(string username, string password, IServerCommunication communication);
        bool Register(string username, string password, IServerCommunication communication);
        bool ChangePassword(string password, IServerCommunication communication);
        bool DeleteAccount(IServerCommunication communication);
    }
}