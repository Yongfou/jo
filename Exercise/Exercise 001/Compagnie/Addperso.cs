using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compagnie
{
    public partial class Addperso : Form
    {
        int number = 0;

        public static TextBox Txtfirstname { get; set; }
        public static TextBox Txtlastname { get; set; }
        public static Label LblNumberclient {get; set;}
        public static DataGridView gridListClient { get; set; }
 
        public Addperso()
        {
        
            InitializeComponent();
            Txtfirstname = txtfirstname;
            Txtlastname = txtlastname;
            LblNumberclient = lblNumberclient;
            gridListClient = GridClient;
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = "";
           
            Random _rnd = new Random();
            number = _rnd.Next(0, 10001);
            id = Convert.ToString(number);
            LblNumberclient.Text = id;
            GlobalVar.idclients.Add(number);

        }

        private void btnAddperson_Click(object sender, EventArgs e)
        {
            new Person();
        }
    }
}
