using Caliburn.Micro;
using KlientTCP.Events;
using KlientTCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.ViewModels
{
    public class RegisterViewModel : Screen
    {
        private string _username;
        private string _password;
        private string _error;
        private IAuthenticator _authenticator;
        private IEventAggregator _aggregator;

        public RegisterViewModel(IAuthenticator authenticator, IEventAggregator aggregator)
        {
            _authenticator = authenticator;
            _aggregator = aggregator;
        }

        public string Username
        {
            get { return _username; }
            set
            {
                _username = value;
                NotifyOfPropertyChange(() => Username);
            }
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
            // Tu sie znajduje kod, który zostanie wywołany po wcisnieciu przycisku
            Error = "";

            if (String.IsNullOrWhiteSpace(Username) || String.IsNullOrWhiteSpace(Password))
            {
                Error = "Username and Password are required";
            }
            else
            {
                // Wywoływanie metody Register z serwisu Authenticator
                if (_authenticator.Register(Username, Password))
                {
                    // Wywolywanie eventu, zeby zmienic widok w aplikacji
                    _aggregator.PublishOnUIThread(new LoginEvent());
                }
            }
        }
    }
}
