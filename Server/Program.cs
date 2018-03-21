using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 3456);
            sock.Bind(ipe);
            EndPoint ep = ipe;
            byte[] receiveData = new byte[10];
            sock.ReceiveFrom(receiveData, ref ep);
            int clientResult = Convert.ToInt32(Encoding.ASCII.GetString(receiveData));
            Random r = new Random();
            int serverResult = r.Next(0, 3);
            if (serverResult == clientResult)
            {
                byte[] sendData = Encoding.ASCII.GetBytes("Hoa");
                sock.SendTo(sendData, ep);
            }
            else if (serverResult == 2 && clientResult == 0 || (serverResult == 0 && clientResult == 1) || (serverResult == 1 && clientResult == 2))
            {
                byte[] sendData = Encoding.ASCII.GetBytes("Thang");
                sock.SendTo(sendData, ep);
            }
            else
            {
                byte[] sendData = Encoding.ASCII.GetBytes("Thua");
                sock.SendTo(sendData, ep);
            }


        }
    }
}
