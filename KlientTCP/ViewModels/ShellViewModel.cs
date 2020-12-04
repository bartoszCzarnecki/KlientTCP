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
    public class ShellViewModel : Conductor<object>, IHandle<LoginEvent>, IHandle<LogoutEvent>
    {
        private WelcomeViewModel _welcomeVM;
        private DashboardViewModel _dashboardVM;
        private IAuthenticator _authenticator;
        private IEventAggregator _aggregator;

        public ShellViewModel(
            DashboardViewModel dashbooarVM,
            WelcomeViewModel welcomeVM,
            IAuthenticator authenticator,
            IEventAggregator aggregator
          )
        {
            _authenticator = authenticator;
            _aggregator = aggregator;
            _welcomeVM = welcomeVM;
            aggregator.Subscribe(this);
            _dashboardVM = dashbooarVM;
            ActivateItem(_welcomeVM);
        }

        public void Handle(LoginEvent message)
        {
            ActivateItem(_dashboardVM);
        }

        public void Handle(LogoutEvent message)
        {
            ActivateItem(_welcomeVM);
        }
    }
}
