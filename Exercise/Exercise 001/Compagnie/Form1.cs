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
            Product prod1 = new Product(6121703, "Patato", 1.50, "brown");

            products.Add(prod1);
           prod1.ViewProduct();
           // MessageBox.Show(prod1.Idproduct.ToString() + "" + prod1.Name + "\n" + prod1.Price.ToString() + "" + prod1.Color);
        }
    }
}
