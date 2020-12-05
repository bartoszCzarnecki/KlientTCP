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
        public void Login(string username, string password)
        {
            this._currentUser = new User(username, password);
        }

        public void Register(string username, string password)
        {
            this._currentUser = new User(username, password);
        }

        public bool IsLoggedIn => _currentUser != null;
    }
}
