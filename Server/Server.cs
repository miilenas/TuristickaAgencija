using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Server
{
    public class Server
    {
        private Socket socket;
        private List<ClientHandler> handlers = new List<ClientHandler>();

        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public bool Start()
        {

            try
            {
                IPEndPoint EndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9999);
                socket.Bind(EndPoint);
                socket.Listen();
                Thread serverNit = new Thread(AcceptClient);
                serverNit.Start();
                serverNit.IsBackground = true;
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return false;
            }

        }
        public void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket, this);
                    handlers.Add(handler);
                    Thread klijentskaNit = new Thread(handler.HandleRequest);
                    klijentskaNit.IsBackground = true;
                    klijentskaNit.Start();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
        public void Stop()
        {
            List<ClientHandler> copy = new List<ClientHandler>(handlers);
            foreach (ClientHandler handler in copy)
            {
                handler.CloseSocket();
            }
            handlers.Clear();
            socket.Close();
        }
        internal void RemoveClient(ClientHandler clientHandler)
        {
            
                handlers.Remove(clientHandler);
            
        }

    }
}
