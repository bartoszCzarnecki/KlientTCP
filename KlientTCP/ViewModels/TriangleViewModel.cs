using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlientTCP.Services;

namespace KlientTCP.ViewModels
{
    public class TriangleViewModel : Screen
    {
        private string _a;
        private string _b;
        private string _c;
        private string _result;
        private IServerCommunication _communication;

        public TriangleViewModel(IServerCommunication communication)
        {
            _communication = communication;
        }

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

        public string Result
        {
            get { return _result; }
            set
            {
                _result = value;
                NotifyOfPropertyChange(() => Result);
            }
        }

        public void HandleButtonClick()
        {
            /* Kod, który zostanie wywołany po wcisnieciu przycisku
             * Proponuje stworzyc nowy serwis na przykladzie `Authenticator`
             * I trzeba będzie go dodac tak samo w pliku Bootstrapper.cs
             */

            Result = "Trójkat ostrokątny";

        }
    }
}
