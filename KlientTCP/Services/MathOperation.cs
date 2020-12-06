using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlientTCP.Services
{
    public class MathOperation : IMathOperation
    {

        public string TriangleType(string values, IServerCommunication communication)
        {
            communication.SendMessage("2");
            string msg = communication.GetMessage();
            communication.SendMessage(values);
            msg = communication.GetMessage();
            return msg;
        }
    }
}
