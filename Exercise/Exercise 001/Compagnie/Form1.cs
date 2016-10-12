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
        Addproduct addproduct = new Addproduct();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {

            GlobalVar.menuproduct.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order o = new Order(1, GlobalVar.products);
            GlobalVar.orders.Add(o);
            GlobalVar.menuorder.Show();
            // MessageBox.Show(GlobalVar.orders[0].OrderProducts[1].Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GlobalVar.menuperson.Show();
        }
    }
}
