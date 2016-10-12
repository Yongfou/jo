using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public class Mot
    {
        public string Value { get; set; }
        public int NChar { get; set; }

        public Mot(string value)
        {
            Value = value;
            NChar = value.Length;
        }
    }
    public class Mots
    {
        //Constante
        //Varaible global

        
        public List<Mot> listmots { get; set; } = new List<Mot>();
        
        public Mots ()
        {
            Regex regex = new Regex(@"(\s+)");
            string sValeurtxt = regex.Replace(AnalyseurTexte.TxtOtexte.Text," ");
            AnalyseurTexte.TxtNtexte.Text = sValeurtxt;
            string[] words = new string[1000];
            words = sValeurtxt.Split(' ',':','\\','/','\'','\r','\t');
            foreach (string Motstrim in words)
            {
                string myStr = Motstrim.Trim(new Char[] {'.',' ',',','/',':','"'}).ToLower();
                Mot myMot = new Mot(myStr);
                listmots.Add(myMot);
            }
            
            new Form1(listmots).Show();

        }
        public void Nmots()
        {
            AnalyseurTexte.TxtNmots.Text = listmots.Count.ToString();

        }
        public void Ncaractere ()
        {
            int totalChar = 0;
            foreach(Mot m in listmots) totalChar += m.NChar;
            AnalyseurTexte.TxtNcaracteres.Text = totalChar.ToString();
        }
        public void NvoyellesNconsonnes()
        {
            int iNvoyelles = 0;
            int iNconsonnes = 0;
            Char[] Voyelle = new Char[] { 'a', 'e', 'i', 'o', 'u','à','â','é','è','ê','ë','ï','î','ù','û','ô','y' };
            foreach (Mot word in listmots )
            {
                foreach(char c in word.Value)
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
            string motpluslong = "";
            foreach (Mot mots in listmots)
            {
                iNlettre = mots.Value.Length;
                if (iNlettre > iPluslettre)
                {
                    iPluslettre = iNlettre;
                    motpluslong = mots.Value;
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
            string[] words = new string[1000];
            listmots.Clear();

        }
        public void ListMots()
        {
            foreach (Mot g in listmots)
            {
                MessageBox.Show(g.Value);
            }

        }
        
    }
}
