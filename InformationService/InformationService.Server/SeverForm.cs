using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformationService.Server
{
    public partial class SeverForm : Form
    {
        private static readonly int servicePort = 4433;
        private static readonly IPAddress serviceIP = IPAddress.Parse("127.0.0.1");
        private Socket listenSocket;
        private bool isRunning;
        private ManualResetEvent manual = new ManualResetEvent(false);
        private SocketAsyncPool argsPool;
        public SeverForm()
        {
            InitializeComponent();
        }

        private void openServer_Click(object sender, EventArgs e)
        {
            //首先，第一点，不能在主线程上while  waitone，这种sb行为都干得出。
            //总之，能不在主线程上做的事就不要在主线程上做。

            Task.Run(() => {
                isRunning = true;
                
                listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPEndPoint ipEndPoint = new IPEndPoint(serviceIP, servicePort);
                listenSocket.Bind(ipEndPoint);
                listenSocket.Listen(100);
                while (isRunning)
                {
                    //这套东西在主线程上执行时，发生卡死的情况是因为主线程waitone了，异步操作里想要通过主线程执行方法，当然也会卡死。
                    manual.Reset();
                    var acceptArgs = argsPool.PopSocketAsyncEventArgs();
                    if (acceptArgs != null)
                    {
                        listenSocket.AcceptAsync(acceptArgs);
                    }
                    manual.WaitOne();
                }
            });
            
        }

        private void stopServer_Click(object sender, EventArgs e)
        {
            isRunning = false;
            listenSocket.Close();
        }

        private void InitOperatePool()
        {
            argsPool = new SocketAsyncPool(100);
            for(int i = 0; i < 100; i++)
            {
                var acceptArgs = new SocketAsyncEventArgs();
                acceptArgs.Completed += (ss, ee) =>
                {
                    manual.Set();
                    this.displayBox.Invoke(new MethodInvoker(delegate()
                    {
                        this.displayBox.Text += Environment.NewLine + "建立了一个连接。";
                    }));
                    var connectedSocket = ee.AcceptSocket;
                    var receiveArgs = new SocketAsyncEventArgs();
                    byte[] bufferTem = new byte[100];
                    receiveArgs.SetBuffer(bufferTem, 0, 100);
                    receiveArgs.Completed += (receiveS, receiveE) =>
                    {
                        this.displayBox.Invoke(new MethodInvoker(delegate()
                        {
                            this.displayBox.Text += Environment.NewLine + Encoding.GetEncoding("GB2312").GetString(receiveE.Buffer);
                        }));
                        connectedSocket.ReceiveAsync(receiveArgs);
                    };
                    connectedSocket.ReceiveAsync(receiveArgs);
                };
                argsPool.PushSocketAsyncEventArgs(acceptArgs);
            }
        }

    }
}
