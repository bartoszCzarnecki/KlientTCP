namespace KlientTCP.Services
{
    public interface IAuthenticator
    {
        bool IsLoggedIn { get; }

        void Login(string username, string password);
        void Register(string username, string password);
    }
}