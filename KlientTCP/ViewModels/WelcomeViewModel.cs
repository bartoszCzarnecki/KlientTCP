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
        private IServerCommunication _communication;

        public WelcomeViewModel(
            LoginViewModel loginVM,
            RegisterViewModel registerVM,
            IServerCommunication communication
            )
        {
            _loginVM = loginVM;
            _registerVM = registerVM;
            _communication = communication;
            _communication.GetMessage();
        }

        public void LoadLoginPage()
        {
            _communication.SendMessage("cancel");
            _communication.GetMessage();
            ActivateItem(_loginVM);
        }

        public void LoadRegisterPage()
        {
            _communication.SendMessage("cancel");
            _communication.GetMessage();
            ActivateItem(_registerVM);
        }
    }
}
