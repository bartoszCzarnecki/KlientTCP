using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        private LoginViewModel _loginVM;
        private RegisterViewModel _registerVM;

        public ShellViewModel(LoginViewModel loginVM, RegisterViewModel registerVM)
        {
            _loginVM = loginVM;
            _registerVM = registerVM;
            LoadLoginPage();
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
