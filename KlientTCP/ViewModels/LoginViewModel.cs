﻿using Caliburn.Micro;
using KlientTCP.Events;
using KlientTCP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace KlientTCP.ViewModels
{
    public class LoginViewModel : Screen
    {
        private string _username;
        private string _password;
        private string _error;
        private IAuthenticator _authenticator;
        private IEventAggregator _aggregator;
        private IServerCommunication _communication;

        public LoginViewModel(IAuthenticator authenticator, IEventAggregator aggregator, IServerCommunication communication)
        {
            _authenticator = authenticator;
            _aggregator = aggregator;
            _communication = communication;
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
            } else
            {
                // Wywoływanie metody Login z serwisu Authenticator
                if (_authenticator.Login(Username, Password, _communication))
                {
                    // Wywolywanie eventu, zeby zmienic widok w aplikacji
                    _aggregator.PublishOnUIThread(new LoginEvent());
                    Username = "";
                    Password = "";
                }
                else
                {
                    Error = "Invalid username or password";
                }
            }
        }
    }
}
