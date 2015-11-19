using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Library
{
    public class FileTransfer
    {
        private static List<int> _portsInUse;
        private static int[] portRange;
        public int ServerPort { get; private set; }
        private IPAddress _ipAddress;
        private IPEndPoint _endpoint;
        private TcpListener _server;
        private Socket _connection;
        private TcpClient _client;
        private string _filePath;

        //Use Loopback adress
        public FileTransfer()
        {
            _ipAddress = IPAddress.Loopback;
        }

        //Specify ip adress.
        public FileTransfer(string ipAdress)
        {
            _ipAddress = IPAddress.Parse(ipAdress);
        }

        public void StartAcceptingClient(TcpListener srv)
        {
            srv.Start();
            _client = srv.AcceptTcpClient(); //Blocking call
            Thread t = new Thread(new ThreadStart(HandleReceiveConnection)); //constantly read the stream; blocking so in a thread
            t.Start();
        }

        public void ReceiveFile(string filePath)
        {
            Generate_portsInUse();
            int port = 5556;
            // _portsInUse.Add(port);
            ServerPort = port;
            _filePath = filePath;

            _endpoint = new IPEndPoint(IPAddress.Any, ServerPort);
            _server = new TcpListener(_endpoint);
            StartAcceptingClient(_server);
        }

        private void HandleReceiveConnection()
        {
            while (_client.Connected)
            {
                using (NetworkStream networkStream = _client.GetStream())
                {
                    //string file = @"c:\temp\tisResult.png";
                    Console.WriteLine("Starting to write file.");
                    using (Stream fileStream = new FileStream(_filePath, FileMode.Create, FileAccess.ReadWrite))
                    {
                        networkStream.CopyTo(fileStream);
                    }
                }
            }
        }

        public void SendFile(string filePath, int serverPort)
        {
            //_filePath = filePath;
            ServerPort = serverPort;
            Socket connection = new Socket(SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endpoint = new IPEndPoint(_ipAddress, ServerPort);
            //string file = @"c:\temp\tis.png";
            connection.Connect(endpoint);
            using (NetworkStream networkStream = new NetworkStream(connection))
            {
                using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
                {
                    fileStream.CopyToAsync(networkStream);
                }
            }
            connection.Shutdown(SocketShutdown.Both);
            connection.Close();
            Console.WriteLine("Client done sending.");
        }

        //public static void ConnectToServer()
        //{
        //    //connection.Connect(remoteEndpoint);

        //    //Thread t = new Thread(new ThreadStart(SendFile));
        //    //t.Start();
        //    Console.WriteLine("Thread started.");
        //}

        private static void Generate_portsInUse()
        {
            if (_portsInUse == null)
            {
                _portsInUse = new List<int>();
            }
        }
    }
}
