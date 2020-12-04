using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.ViewModels
{
    public class TriangleViewModel : Screen
    {
        private string _a;
        private string _b;
        private string _c;

        public string A
        {
            get { return _a; }
            set
            {
                _a = value;
                NotifyOfPropertyChange(() => A);
            }
        }

        public string B
        {
            get { return _b; }
            set
            {
                _b = value;
                NotifyOfPropertyChange(() => B);
            }
        }

        public string C
        {
            get { return _c; }
            set
            {
                _c = value;
                NotifyOfPropertyChange(() => C);
            }
        }

        public void HandleButtonClick()
        {

        }
    }
}
