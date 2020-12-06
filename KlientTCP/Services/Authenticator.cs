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
        public bool Login(string username, string password, IServerCommunication communication)
        {
            communication.SendMessage("1");
            communication.GetMessage();
            communication.SendMessage(username + " " + password);
            string msg = communication.GetMessage().Substring(0, 5);
            if (msg == "Ktora")
            {
                _currentUser = new User(username, password);
                return true;
            }
            else
            {
                // Error
                return false;
            }
        }

        public bool Register(string username, string password, IServerCommunication communication)
        {
            communication.SendMessage("2");
            communication.GetMessage();
            communication.SendMessage(username + " " + password);
            string msg = communication.GetMessage().Substring(0, 5);
            if (msg == "Ktora")
            {
                _currentUser = new User(username, password);
                return true;
            }
            else
            {
                // Error
                return false;
            }
        }

        public bool ChangePassword(string password, IServerCommunication communication)
        {
            communication.SendMessage("1");
            communication.GetMessage();
            communication.SendMessage(_currentUser.Password + " " + password);
            string msg = communication.GetMessage().Substring(0, 5);
            if (msg == "Ktora")
            {
                _currentUser.Password = password;
                return true;
            }
            else
            {
                // Error
                return false;
            }
        }

        public bool DeleteAccount(IServerCommunication communication)
        {
            communication.SendMessage("3");
            communication.GetMessage();
            return true;
        }

        public bool IsLoggedIn => _currentUser != null;
    }
}
