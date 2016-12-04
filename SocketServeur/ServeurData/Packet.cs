using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServeurData;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net;

namespace ServeurData
{
    [Serializable]
    public class Packet
    {
        const string FICHIER = "..\\..\\..\\ListeClients.txt";
        public List<string> Gdata;
        public string NOM;
        public int packetInt;
        public bool packetbool;
        public string senderID;      
        public PacketType packetType;
        public Packet(PacketType type, string senderID,string nom)
        {
            Gdata = new List<string>();
            this.senderID = senderID;
            this.packetType = type;
            this.NOM = nom;
            if (File.Exists(FICHIER))
            {
                StreamReader LectureFichier = new StreamReader(FICHIER);
                string sTClient = LectureFichier.ReadToEnd();
                LectureFichier.Close();
                StreamWriter EcrireFichier = new StreamWriter(FICHIER, true);
                if (!sTClient.Contains(NOM) & !sTClient.Contains(senderID))
                {
                    EcrireFichier.WriteLine( "Nom d'usagé : " + NOM + "\n"+ "Numero d'authentification : " + senderID + "\n");
                }
                EcrireFichier.Close();
                

            }
        }

        public Packet(byte[] packetbytes)
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream(packetbytes);
            Packet p = (Packet)bf.Deserialize(ms);
            ms.Close();
            this.Gdata = p.Gdata;
            this.packetInt = p.packetInt;
            this.packetbool = p.packetbool;
            this.senderID = p.senderID;
            this.packetType = p.packetType;
        }
        public byte [] Tobytes()
        {
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();

            bf.Serialize(ms, this);
            byte[] bytes = ms.ToArray();
            ms.Close();
            return bytes;
        }

        public static string PrendIP()
        {
            IPAddress[] ips = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress i in ips)
            {
                if (i.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                    return i.ToString();
            }
            return "127.0.0.1";
        }
    }
    public enum PacketType
    {
        Registration,
        Chat,
        nom
    }
}
