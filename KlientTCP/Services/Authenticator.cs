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
            // TODO
            _currentUser = new User(username, password);
            return true;
        }

        public bool Register(string username, string password)
        {
            // TODO
            _currentUser = new User(username, password);
            return true;
        }

        public bool IsLoggedIn => _currentUser != null;
    }
}
