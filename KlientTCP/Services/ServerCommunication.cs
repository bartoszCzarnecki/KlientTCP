using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace KlientTCP.Services
{
    public class ServerCommunication : IServerCommunication
    {

        TcpClient client;
        int buffer_size = 1024;

        public ServerCommunication()
        {
            client = new TcpClient();
            client.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000));
        }

        bool CheckPort(int port)
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
            try
            {
                NetworkStream stream = client.GetStream();
                stream.ReadTimeout = 200;
                byte[] buffer = new byte[buffer_size];
                int msg_len = stream.Read(buffer, 0, buffer_size);
                string msg = System.Text.Encoding.UTF8.GetString(buffer).Replace("\0", string.Empty);
                Array.Clear(buffer, 0, buffer_size);
                return msg;
            } catch(IOException e)
            {
                return e.Message;
            }
        }
    }
}
