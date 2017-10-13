using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PhanTanDat_b3_b1_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, 1235);
            Socket S = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            S.Bind(ipep);

            Console.WriteLine("Waiting for a client to connect");

            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 0);
            EndPoint Remote = (EndPoint)(sender);

            byte[] data = new byte[4];
            S.ReceiveFrom(data, ref Remote);
            int clientchoosen = BitConverter.ToInt32(data, 0);

            Random rand = new Random();
            int serverchoosen = new Random().Next(0, 2);


            //int serverchoosen = rand.Next(0, 2);


            if(clientchoosen == serverchoosen)
            {
                byte[] send = Encoding.ASCII.GetBytes("Hòa");
                S.SendTo(send, Remote);
            }

            if(clientchoosen == 0 && serverchoosen == 1)
            {
                byte[] send = Encoding.ASCII.GetBytes("Thắng");
                S.SendTo(send, Remote);
            }

            if(clientchoosen == 1 && serverchoosen == 2)
            {
                byte[] send = Encoding.ASCII.GetBytes("Thua");
                S.SendTo(send, Remote);
            }
        }
    }
}
