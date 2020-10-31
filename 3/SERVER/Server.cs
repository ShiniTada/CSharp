using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace SERVER
{
    class Server
    {
        private static TcpListener tcpListener;
        private List<Client> clients = new List<Client>();

        public void AddConnection(Client clientObject)
        {
            clients.Add(clientObject);
        }

        public void RemoveConnection(Client client)
        {
            if (client != null)
            {
                clients.Remove(client);
            }
        }

        public void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IPAddress.Any, 8888);
                tcpListener.Start();
                Console.WriteLine("Waiting for a connection...");

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    Client clientObject = new Client(tcpClient, this);
                    Thread clientThread = new Thread(new ThreadStart(clientObject.Execution));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Disconnect();
            }
        }

        protected internal void Disconnect()
        {
            tcpListener.Stop();

            foreach (Client client in clients)
            {
                client.Close();
            }
            Environment.Exit(0);
        }
    }
}
