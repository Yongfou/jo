using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public class Mots
    {
        //Constante
        //Varaible global
        string sValeurtxt3 = AnalyseurTexte.TxtOtexte.Text;
        int iNombre = 0;
        int iNcaractere = 0;
        string motpluslong = "";
        int iNvoyelles = 0;
        int iNconsonnes = 0;


        public static List<string> list { get; set; }
        public List<string> listmots { get; set; }

        string[] words = new string[1000];

        public string mots { get; set; }
        public Mots ()
        {
            string sValeurtxt1 = "";
            string sValeurtxt2 = "";
            Regex regex = new Regex(@"(\s+)");
            sValeurtxt1 = regex.Replace(AnalyseurTexte.TxtOtexte.Text," "); 
            sValeurtxt2 = sValeurtxt1;
            words = sValeurtxt2.Split(' ',':','\\','/','\'','\r','\t');           
            list = words.ToList();
            AnalyseurTexte.TxtNtexte.Text = sValeurtxt2;

            foreach (string Motstrim in list)
            {
                string tata = Motstrim.Trim(new Char[] {'.',' ',',','/',':','"'}).ToLower();
                MessageBox.Show(tata);
                listmots.Add(tata);
                Form1.DataGridView1.DataSource = listmots.ToList();
            }
           
        }
        public void Nmots ()
        {
            iNombre = words.Length;
            AnalyseurTexte.TxtNmots.Text = iNombre.ToString();

        }
        public void Ncaractere ()
        {
            iNcaractere = sValeurtxt3.Length;
            AnalyseurTexte.TxtNcaracteres.Text = iNcaractere.ToString();
        }
        public void NvoyellesNconsonnes()
        {
            Char[] Voyelle = new Char[] { 'a', 'e', 'i', 'o', 'u','à','â','é','è','ê','ë','ï','î','ù','û','ô','y' };
            foreach (string word in listmots )
            {
                foreach(char c in word)
                {
                    if (Char.IsLetter(c))
                    {
                        
                        if (Voyelle.Contains(c))
                        {
                            iNvoyelles++;
                        }
                        else
                        {
                            iNconsonnes++;                          
                        }
                    }

                }             
            }

            AnalyseurTexte.TxtNvoyelles.Text = iNvoyelles.ToString();
            AnalyseurTexte.TxtNconsonnes.Text = iNconsonnes.ToString();

        }
        public void Motspluslong()
        {
            int iNlettre = 0;
            int iPluslettre = 0;
            foreach (string mots in listmots)
            {
                iNlettre = mots.Length;
                if (iNlettre > iPluslettre)
                {
                    iPluslettre = iNlettre;
                    motpluslong = mots;
                }              
            }
            AnalyseurTexte.TxtMotpluslong.Text = motpluslong;
        }
        public void Resettxt()
        {
           
            AnalyseurTexte.TxtNtexte.Text = "";
            AnalyseurTexte.TxtOtexte.Text = "";
            AnalyseurTexte.TxtNmots.Text = "";
            AnalyseurTexte.TxtNcaracteres.Text = "";
            AnalyseurTexte.TxtNvoyelles.Text = "";
            AnalyseurTexte.TxtNconsonnes.Text = "";
            AnalyseurTexte.TxtMotpluslong.Text = "";
            int iNombre = 0;
            int iNcaractere = 0;
            string motpluslong = "";
            int iNvoyelles = 0;
            int iNconsonnes = 0;
            string[] words = new string[1000];
            listmots.Clear();
            list.Clear();

        }
        public void ListMots()
        {
            foreach (string g in listmots)
            {
                MessageBox.Show(g);
            }

        }
        
    }
}
