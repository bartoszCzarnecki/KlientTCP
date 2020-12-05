using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.Models
{
    class User
    {
        private string _username;
        private string _password;

        public User(string username, string password)
        {
            this._username = username;
            this._password = password;
        }
    }
}
