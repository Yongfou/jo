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
    public partial class AddOrder : Form
    {
        public AddOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id =(txtidclient.Text);
            //(GlobalVar.products.Find(x => x.Idproduct == Id).ToString());
            //string Id = (txtID.Text);
            Person p = new Person();
            p = (GlobalVar.persons.Find(x => x.Numberclient == Id));
            txtFirstName.Text = p.FName;
            txtLastName.Text = p.LName;
            //lblNumberclient.Text = p.Numberclient.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32 (txtidproduct.Text);
            Product k = new Product();
            k = GlobalVar.products.Find(x => x.Idproduct == Id);
            MessageBox.Show(k.ToString());
        }
    }
}
