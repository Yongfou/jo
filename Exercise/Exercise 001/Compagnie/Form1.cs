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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Product> products = new List<Product>();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            Addproduct addproduct = new Addproduct();
            addproduct.Show();
            this.Hide();
        }

    }
}
