using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServeurData;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Net;



namespace Serveur
{
    class Serveur
    {
        static Socket CaptureSocket;
        static List<ClientData> _client;

        /// <summary>
        /// Auteur: Sébastien Paquet
        /// Description: Démare le serveur.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Startint serveur on " + Packet.PrendIP());
            CaptureSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _client = new List<ClientData>();

            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.PrendIP()), 4242);
            CaptureSocket.Bind(ip);
            Thread capteThread = new Thread(CapteThread);
            capteThread.Start();
        }
       
        // capte les clients qui essayent de se connecter.
        static void CapteThread()
        {
            for (;;)
            {
                CaptureSocket.Listen(0);
                _client.Add(new ClientData(CaptureSocket.Accept()));
                
            }
        }

        // recoit les information de chauqe client.
        public static void Data_Entrant(object cSocket)
        {
            Socket clientSocket = (Socket)cSocket;
            byte[] byBuffer;
            int iBytes;

            for (; ; )
            {
                try
                {
                    byBuffer = new byte[clientSocket.SendBufferSize];
                    iBytes = clientSocket.Receive(byBuffer);
                    if (iBytes > 0)
                    {
                        Packet packet = new Packet(byBuffer);
                        DataAssignation(packet);
                    }
                }
                catch(SocketException ex)
                {
                    Console.WriteLine(" client disconnecter");
                }
            }
        }

        //data assignation.
        public static void DataAssignation (Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.Chat:
                    foreach (ClientData c in _client)
                    {
                        c.clientSocket.Send(p.Tobytes());
                    }
                    break;
            }
        }

    }
    class ClientData
    {
        public Socket clientSocket;
        public Thread clientThread;//
        public string id;
        

        public ClientData()
        {
            id = Guid.NewGuid().ToString();
            clientThread = new Thread(Serveur.Data_Entrant);
            clientThread.Start(clientSocket);
            EnvoieRegistrationPacket();
        }
        public ClientData( Socket clientSocket)
        {
            this.clientSocket = clientSocket;
            id = Guid.NewGuid().ToString();
            clientThread = new Thread(Serveur.Data_Entrant);
            clientThread.Start(clientSocket);
            EnvoieRegistrationPacket();
        }
        public void EnvoieRegistrationPacket()
        {
            Packet p = new Packet(PacketType.Registration, "serveur");
            p.Gdata.Add(id);       
                clientSocket.Send(p.Tobytes());            
        }
    }
}
