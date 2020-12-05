using KlientTCP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.Services
{
    public class Authenticator : IAuthenticator
    {
        private User _currentUser;
        public bool Login(string username, string password)
        {
            // Tu dodaj logike logowania
            _currentUser = new User(username, password);
            return true;
        }

        public bool Register(string username, string password)
        {
            // Tu dodaj logike rejestracji
            _currentUser = new User(username, password);
            return true;
        }

        public bool ChangePassword(string username, string password)
        {
            // Tu dodaj logike zmiany hasla
            return true;
        }

        public bool DeleteUser(string username, string password)
        {
            // Tu dodaj logike usuwania uzytkownika
            return true;
        }

        public bool IsLoggedIn => _currentUser != null;
    }
}
