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

            string msg = communication.GetMessage();
            communication.SendMessage("get_status");
            if (communication.GetMessage() != "triangle")
                communication.SendMessage("2");
            msg = communication.GetMessage();
            communication.SendMessage(values);
            msg = communication.GetMessage();
            return msg;
        }
    }
}
