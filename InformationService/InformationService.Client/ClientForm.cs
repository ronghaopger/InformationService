using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationService.Client
{
    public partial class ClientForm : Form
    {
        private static readonly int servicePort = 4433;
        private static readonly IPAddress serviceIP = IPAddress.Parse("127.0.0.1");
        private Socket socket;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void online_Click(object sender, EventArgs e)
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint ipEndPoint = new IPEndPoint(serviceIP, servicePort);
            var socketArgs = new SocketAsyncEventArgs();
            socketArgs.RemoteEndPoint = ipEndPoint;
            socketArgs.Completed += (se, ee) =>
            {
                this.displayBox.Invoke(new MethodInvoker(delegate()
                {
                    this.displayBox.Text += "已上线";
                }));
            };
            socket.ConnectAsync(socketArgs);
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            byte[] sendMessage = Encoding.GetEncoding("GB2312").GetBytes(this.sendMessageBox.Text);
            var sendArgs = new SocketAsyncEventArgs();
            byte[] bufferTem = new byte[100];
            sendArgs.SetBuffer(bufferTem,0, 100);
            Array.Copy(sendMessage, sendArgs.Buffer, sendMessage.Length);
            sendArgs.Completed += (ss, ee) => {
                this.sendMessageBox.Invoke(new MethodInvoker(delegate() {
                    this.sendMessageBox.Text = string.Empty;                
                }));
            };
            socket.SendAsync(sendArgs);
        }
    }
}
