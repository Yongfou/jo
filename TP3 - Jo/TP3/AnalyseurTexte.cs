using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class AnalyseurTexte : Form
    {
        public static TextBox TxtOtexte { get; set; }
        public static TextBox TxtNtexte { get; set; }
        public static TextBox TxtNmots { get; set; }
        public static TextBox TxtNcaracteres { get; set; }
        public static TextBox TxtNvoyelles { get; set; }
        public static TextBox TxtNconsonnes { get; set; }
        public static TextBox TxtMotpluslong { get; set; }

        public AnalyseurTexte()
        {
            InitializeComponent();
            TxtOtexte = txtOtexte;
            TxtNtexte = txtNtexte;
            TxtNmots = txtNmots;
            TxtNcaracteres = txtNcarateres;
            TxtNvoyelles = txtNvoyelles;
            TxtNconsonnes = txtNconsonnes;
            TxtMotpluslong = txtMotpluslong;

        }


        public void btnMisejour_Click(object sender, EventArgs e)
        {    

            Mots mots = new Mots ();
            mots.Nmots();
            mots.Ncaractere();
            mots.NvoyellesNconsonnes();
            mots.Motspluslong();
            //mots.ListMots();
        }

        public void btnEffacertxt_Click(object sender, EventArgs e)
        {
            Mots mots = new Mots();
            mots.Resettxt();
            /*txtNtexte.Text = "";
            txtOtexte.Text = "";
            txtNmots.Text = "";
            txtNcarateres.Text = "";
            txtNvoyelles.Text = "";
            txtNconsonnes.Text = "";
            txtMotpluslong.Text = "";
            */
        }

        private void AnalyseurTexte_Load(object sender, EventArgs e)
        {

        }
    }
}
