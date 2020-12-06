using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace KlientTCP.Services
{
    public interface IServerCommunication
    {

        void SendMessage(string message);

        string GetMessage();
    }
}
