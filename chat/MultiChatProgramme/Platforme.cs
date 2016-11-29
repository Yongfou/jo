using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mnemoTIC.Programmation;
using ServeurData;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace MultiChatProgramme
{
    public partial class Platforme : Form
    {
        public static TextBox Txtmessage { get; set; }
        public static Socket Principal;
        public static string _sNom;
        public static string _sId;
        public static string _sIP;
        public static string _sMessage;
        public Platforme()
        {
            InitializeComponent();
            Txtmessage = txtMessage;
        }

        private void Platforme_Load(object sender, EventArgs e)
        {
            _sNom = Formulaires.DemanderValeur(" Quel est votre nom d'utilisateur");
        A:
            _sIP = Formulaires.DemanderValeur(" IP :");

            Principal = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(_sIP), 4242);

            try
            {
                Principal.Connect(ipe);

            }
            catch
            {
                Console.WriteLine("N'existe pas");
                Thread.Sleep(15000);
                goto A;
            }
            Thread t = new Thread(DataEntrant);
            t.Start();
            for (;;)
            {
                txtPrincipal.AppendText("::>");
                string input = Console.ReadLine();
                Packet p = new Packet(PacketType.Chat, _sId);
                p.Gdata.Add(_sNom);
                p.Gdata.Add(input);
                Principal.Send(p.Tobytes());
            }
        }
        static void DataEntrant()
        {
            byte[] byBuffer;
            int iBytes;

            for (;;)
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
                catch (SocketException ex)
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
                    _sId = p.Gdata[0];
                    break;
                case PacketType.Chat:
                    //ConsoleColor c = Console.ForegroundColor;
                   // Console.ForegroundColor = ConsoleColor.Cyan;
                    Txtmessage.Invoke(new Action(() => Txtmessage.Text =(p.Gdata[0] + ": " + p.Gdata[1])+ Environment.NewLine));
                    //Console.ForegroundColor = c;
                    break;

            }
        }

        private void BtnEnvoyer_Click(object sender, EventArgs e)
        {
           // Platforme platforme = (Platforme);
            txtPrincipal.AppendText("::>");
            _sMessage = txtMessage.Text;
            Packet p = new Packet(PacketType.Chat, _sId);
            p.Gdata.Add(_sNom);
            p.Gdata.Add(_sMessage);
            Principal.Send(p.Tobytes());
           
        }
    }

}
