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

        public DeleteAccountViewModel(IAuthenticator authenticator, IEventAggregator aggregator)
        {
            _authenticator = authenticator;
            _aggregator = aggregator;
        }

        public void HandleYesButtonClick()
        {
            if (_authenticator.DeleteAccount())
            {
                _aggregator.PublishOnUIThread(new LogoutEvent());
            }
        }

        public void HandleNoButtonClick()
        {

        }
    }
}
