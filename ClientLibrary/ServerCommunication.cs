using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ClientLibrary
{
    class ServerCommunication
    {

        TcpClient client;
        int buffer_size = 1024;

        public ServerCommunication(IPAddress IP, int port)
        {
            if (!CheckPort(port))
            {
                port = 8000;
                throw new Exception("błędna wartość portu, ustawiam port na 8000");
            }

            client = new TcpClient();
            client.Connect(new IPEndPoint(IP, port));
        }

        private bool CheckPort(int port)
        {
            if (port < 1024 || port > 49151) return false;
            return true;
        }

        public void SendMessage(string message)
        {
            byte[] encoded = new ASCIIEncoding().GetBytes(message);
            client.GetStream().Write(encoded, 0, message.Length);
        }

        public string GetMessage()
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[buffer_size];
            int msg_len = stream.Read(buffer, 0, buffer_size);
            string msg = System.Text.Encoding.UTF8.GetString(buffer);
            return msg;
        }
    }
}
