using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace InformationService.Server
{
    public class SocketAsyncPool
    {
        //对于这种高并发的情景，不应该lock吗？？
        private Stack<SocketAsyncEventArgs> argsPool;
        public SocketAsyncPool(int capacity)
        {
            argsPool = new Stack<SocketAsyncEventArgs>(capacity);
        }
        public void PushSocketAsyncEventArgs(SocketAsyncEventArgs item)
        {
            if (item == null)
                return;
            argsPool.Push(item);
        }
        public SocketAsyncEventArgs PopSocketAsyncEventArgs()
        {
            if (argsPool.Count == 0)
                return null;
            return argsPool.Pop();
        }
    }
}
