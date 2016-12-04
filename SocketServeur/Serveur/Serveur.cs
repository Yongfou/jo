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
        const string FICHIER = "..\\..\\..\\ListeClients.txt";
        static Socket CaptureSocket;
        public static List<ClientData> _client;

        /// <summary>
        /// Auteur: Sébastien Paquet
        /// Description: Démare le serveur.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            StreamWriter EListClient = new StreamWriter(FICHIER); 
            EListClient.WriteLine("",false);
            EListClient.Close();

            Console.WriteLine("Startint serveur on " + Packet.PrendIP());
            CaptureSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _client = new List<ClientData>();
            IPEndPoint ip = new IPEndPoint(IPAddress.Parse(Packet.PrendIP()), 4242);
            CaptureSocket.Bind(ip);
            Thread capteThread = new Thread(CapteThread);
            
            capteThread.Start();
            Thread pingpongThread = new Thread(new ThreadStart(CheckIfStillConnected));
            pingpongThread.Start();
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
            
            for (;;)
            {
                Thread.Sleep(20);
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
                catch (SocketException ex)
                {
                    Console.WriteLine(" client disconnecter");
                    for (int i = 0; i < _client.Count; i++)
                    {
                        if(clientSocket.Connected == false)
                            ((Socket)_client[i].clientSocket).Close();
                            _client.Remove(_client[i]);
                            i--;
                        }
                    }
                        //clientSocket.();
                        //foreach (ClientData cd in _client)
                        //while(true)
                        //{
                        //    if (cSocket == cd.clientSocket)
                        //        //cd.clientThread.Join();
                        //        _client.Remove(cd);
                        //    clientSocket.Close();
                        //    //goto B;
                        //    return;
                        //}
                    
                if (_client.Count == 0)
                {
                    Environment.Exit(0);
                }
                //CaptureSocket.Close();
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
        public static void CheckIfStillConnected()
        {
            /* Etant donné que la propriété .Connected d'une socket n'est pas
             * mise à jour lors de la déconnexion d'un client sans que l'on ait
             * prélablement essayé de lire ou d'écrire sur cette socket, cette méthode
             * parvient à déterminer si une socket cliente s'est déconnectée grce à la méthode
             * poll. On effectue un poll en lecture sur la socket, si le poll retourne vrai et que
             * le nombre de bytes disponible est 0, il s'agit d'une connexion terminée*/
            while (true)
            {
                for (int i = 0; i < _client.Count; i++)
                {
                    if (((Socket)_client[i].clientSocket).Poll(10, SelectMode.SelectRead) && ((Socket)_client[i].clientSocket).Available == 0)
                    {   
                            Console.WriteLine("Client " + ((Socket)_client[i].clientSocket).GetHashCode() + " déconnecté");
                            ((Socket)_client[i].clientSocket).Close();
                            _client.Remove(_client[i]);
                            i--;
                    }
                }
                Thread.Sleep(1);
            }
        }
    }

    class ClientData
    {
        public Socket clientSocket;
        public Thread clientThread;//
        public string id;

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
            Packet p = new Packet(PacketType.Registration, "serveur","");
            p.Gdata.Add(id);       
            clientSocket.Send(p.Tobytes());            
        }
    }

}
