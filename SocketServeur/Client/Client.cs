using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServeurData;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


namespace Client
{
    class Client
    {
        public static Socket Principal;
        public static string nom;
        public static string id;
        static void Main(string[] args)            
        {
            Console.Write("enter nom");
            nom = Console.ReadLine();
        A: Console.Clear();
            Console.Write("Enter host ip : ");
            string ip = Console.ReadLine();

            Principal = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), 4242);

            try
            {
                Principal.Connect(ipe);
                
            }
            catch
            {
                Console.WriteLine("N'existe pas");
                Thread.Sleep(3000);
                goto A;
            }
            Thread t = new Thread(DataEntrant);
            t.Start();

            for (;;)
            {
                string ligne = "";               
                Console.Write("::>");
                string input = Console.ReadLine();
                if (input == "quit" | input == "Q")
                {
                    Environment.Exit(0);
                }
                Packet p = new Packet(PacketType.Chat, id,nom);
                if (input == "listeclients")
                {
                    StreamReader ListClient = new StreamReader("..\\..\\..\\ListeClients.txt");
                    while (!ListClient.EndOfStream)
                    {
                        ligne = ListClient.ReadLine();
                        Console.WriteLine(ligne);
                    }
                    ListClient.Close();
                }
                else
                {
                    p.Gdata.Add(nom);
                    p.Gdata.Add(input);
                    Principal.Send(p.Tobytes());
                }
                

            }
        }
        static void DataEntrant()
        {
            byte[] byBuffer;
            int iBytes;

            for (; ; )
            {
                try
                {
                    byBuffer = new byte[Principal.SendBufferSize];
                    iBytes = Principal.Receive(byBuffer);
                    if (iBytes > 0)
                    {
                        DataAssignation(new Packet(byBuffer));
                    }
                }
                catch(SocketException ex)
                {
                    Console.WriteLine("Serveur disconnecter");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
               
            }
        }
        static void DataAssignation(Packet p)
        {
            switch (p.packetType)
            {
                case PacketType.Registration:            
                    id = p.Gdata[0];
                        break;
                case PacketType.Chat:
                    ConsoleColor c = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(p.Gdata[0] + ": " + p.Gdata[1]);
                    Console.ForegroundColor = c;
                    break;

            }
        }


    }
}
