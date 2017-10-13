using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace PhanTanDat_b3_b1_Client
{
    public partial class Client : Form
    {
        Socket C;
        IPEndPoint ipep;
        EndPoint remote;
        
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            C = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            ipep = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
            remote = (EndPoint)ipep;
        }

        private void btn_Keo_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Kéo";
            int a = 0;
            byte[] send = BitConverter.GetBytes(a);
            C.SendTo(send, remote);

            byte[] rec = new byte[20];
            remote = (EndPoint)ipep;
            C.ReceiveFrom(rec, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(rec);
        }

        private void btn_bua_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Búa";
            int a = 1;
            byte[] send = BitConverter.GetBytes(a);
            C.SendTo(send, remote);

            byte[] rec = new byte[20];
            remote = (EndPoint)ipep;
            C.ReceiveFrom(rec, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(rec);
        }

        private void btn_bao_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bao";
            int a = 2;
            byte[] send = BitConverter.GetBytes(a);
            C.SendTo(send, remote);

            byte[] rec = new byte[20];
            remote = (EndPoint)ipep;
            C.ReceiveFrom(rec, ref remote);
            textBox2.Text = Encoding.ASCII.GetString(rec);
        }
         
            //byte[] data = new byte[4];
            //C.ReceiveFrom(data, ref Remote);
            //int serverchoosen = BitConverter.ToInt32(data, 0);
            //Random rand = new Random();
            //int clientchoosen = new Random().Next(0, 2);
            //if(clientchoosen == serverchoosen)
            //{
            //    byte[] send = Encoding.ASCII.GetBytes("Hòa");
            //    C.SendTo(send, Remote);
            //}

            //if(clientchoosen == 0 && serverchoosen == 1)
            //{
            //    byte[] send = Encoding.ASCII.GetBytes("Thắng");
            //    C.SendTo(send, Remote);
            //}

            //if(clientchoosen == 1 && serverchoosen == 2)
            //{
            //    byte[] send = Encoding.ASCII.GetBytes("Thua");
            //    C.SendTo(send, Remote);
            //}
    }
}
