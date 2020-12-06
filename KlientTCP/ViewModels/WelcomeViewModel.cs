using Caliburn.Micro;
using System;
using KlientTCP.Services;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.ViewModels
{
    public class WelcomeViewModel : Conductor<Object>
    {
        private LoginViewModel _loginVM;
        private RegisterViewModel _registerVM;

        public WelcomeViewModel(
            LoginViewModel loginVM,
            RegisterViewModel registerVM,
            IServerCommunication communication
            )
        {
            _loginVM = loginVM;
            _registerVM = registerVM;
            communication.GetMessage();
        }

        public void LoadLoginPage()
        {
            ActivateItem(_loginVM);
        }

        public void LoadRegisterPage()
        {
            ActivateItem(_registerVM);
        }
    }
}
