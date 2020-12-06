using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KlientTCP.Services;

namespace KlientTCP.Events
{
    public class LogoutEvent
    {
        public LogoutEvent(IServerCommunication communication)
        {
            communication.SendMessage("cancel");
        }
    }
}
