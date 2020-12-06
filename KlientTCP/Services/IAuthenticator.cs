namespace KlientTCP.Services
{
    public interface IAuthenticator
    {
        bool IsLoggedIn { get; }

        bool Login(string username, string password);

        bool Register(string username, string password);

    }
}