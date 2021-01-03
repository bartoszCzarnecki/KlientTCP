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
        private IMathOperation _mathOperation;

        public TriangleViewModel(IServerCommunication communication, IMathOperation mathOperation)
        {
            _communication = communication;
            _mathOperation = mathOperation;
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
            Result = "";

            if (IsInteger(A) && IsInteger(B) && IsInteger(C))
            {
                Result = _mathOperation.TriangleType(A + " " + B + " " + C, _communication);
                A = "";
                B = "";
                C = "";
            } else
            {
                Result = "A, B and C must be integers";
            }

        }

        private bool IsInteger(string number)
        {
            return int.TryParse(number, out _);
        }
    }
}
