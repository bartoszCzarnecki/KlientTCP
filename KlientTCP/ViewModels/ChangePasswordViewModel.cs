using Caliburn.Micro;
using KlientTCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.ViewModels
{
    public class ChangePasswordViewModel : Screen
    {
        private string _password;
        private string _password2;
        private string _error;
        private IAuthenticator _authenticator;

        public ChangePasswordViewModel(IAuthenticator authenticator)
        {
            _authenticator = authenticator;
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => Password);
            }
        }

        public string Password2
        {
            get { return _password2; }
            set
            {
                _password2 = value;
                NotifyOfPropertyChange(() => Password2);
            }
        }

        public string Error
        {
            get { return _error; }
            set
            {
                _error = value;
                NotifyOfPropertyChange(() => Error);
            }
        }

        public void HandleButtonClick()
        {
            Error = "";

            if (String.IsNullOrWhiteSpace(Password) || String.IsNullOrWhiteSpace(Password2))
            {
                Error = "Fields are empty";
            }
            else if (Password != Password2)
            {
                Error = "Passwords must be the same";
            }
            else
            {
                _authenticator.ChangePassword(Password);
            }
        }
    }
}
