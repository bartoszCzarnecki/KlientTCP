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
    public class DeleteAccountViewModel : Screen
    {
        private IAuthenticator _authenticator;
        private IEventAggregator _aggregator;
        private IServerCommunication _communication;

        public DeleteAccountViewModel(IAuthenticator authenticator, IEventAggregator aggregator, IServerCommunication communication)
        {
            _authenticator = authenticator;
            _aggregator = aggregator;
            _communication = communication;
        }

        public void HandleYesButtonClick()
        {
            if (_authenticator.DeleteAccount(_communication))
            {
                _aggregator.PublishOnUIThread(new LogoutEvent());
            }
        }

        public void HandleNoButtonClick()
        {

        }
    }
}
