using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Text;

namespace SERVER
{
    class Client
    {
        public string id;
        private NetworkStream stream;
        private TcpClient tcpClient;
        private Server server;

        public Client(TcpClient tcpClient, Server server)
        {
            this.tcpClient = tcpClient;
            this.server = server;
            this.server.AddConnection(this);
        }

        public void Execution()
        {
            try {
                stream = tcpClient.GetStream();
                string request;
                while (true) {
                    request = RecieveRequest();
                    Console.WriteLine("Incoming request "+ request);
                    try {
                        doAction(request);
                    } catch (IndexOutOfRangeException) {
                        Console.WriteLine("No such request in list");
                    } catch (Exception) {
                        Console.WriteLine("Request <" + request + "> failed");
                    } 
                }
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                server.RemoveConnection(this);
                Close();
            }
        }

        public void doAction(string actionCode)
        {
            switch (actionCode)
            {
                case "getRecords":
                    SendRecords();
                    break;
                case "save":
                    SaveReport();
                    break;
                default:
                    Console.WriteLine("Вы выбрали несуществующие действие.");
                    break;
            }
        }

        public void Close()
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (tcpClient != null)
            {
                tcpClient.Close();
            }
        }

        public void SendRecords()
        {
            string records = string.Join(";", ServerUtil.GetRecords());
            byte[] data = BitConverter.GetBytes(records.Length);
            stream.Write(data, 0, data.Length);
            data = Encoding.Unicode.GetBytes(records);
            stream.Write(data, 0, data.Length);
        }

        public void SaveReport()
        {
            string[] records = RecieveRequest().Split(';');
            ServerUtil.SaveRecords(new List<string>(records));
        }

        private string RecieveRequest()
        {
            byte[] data = new byte[4];
            stream.Read(data, 0, 4);
            int size = BitConverter.ToInt32(data, 0) * 2;
            Console.WriteLine("Incoming size = " + size.ToString());
            data = new byte[size];

            stream.Read(data, 0, size);
            return Encoding.Unicode.GetString(data);
        }
    }
}
