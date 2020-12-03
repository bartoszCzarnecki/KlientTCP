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
        public ShellViewModel()
        {
            LoadLoginPage();          
        }

        public void LoadLoginPage()
        {
            ActivateItem(new LoginViewModel());
        }

        public void LoadRegisterPage()
        {
            ActivateItem(new RegisterViewModel());
        }
    }
}
