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
    public partial class Addproduct : Form
    {
        int i = 0;
        public Addproduct()
        {
            InitializeComponent();
         

        }
        List<Product> products = new List<Product>();
        private void button1_Click(object sender, EventArgs e)
        {
            
            string sNom = txtNom.Text.ToString(); ;
            int idproduit = Convert.ToInt32(txtidproduct.Text.ToString()); ;
            double price = Convert.ToDouble(txtidproduct.Text.ToString()) ;
            string color = Convert.ToString( cmbcolor.SelectedItem.ToString());
          
            // sNom = txtNom.Text.ToString();
            //idproduit = Convert.ToInt32 (txtidproduct.Text.ToString());
           // price = Convert.ToDouble(txtprice.Text.ToString());
           // color = cmbcolor.SelectedText.ToString();
            Product produit001 = new Product(idproduit, sNom, price, color);
            products.Add(produit001);
            
            sNom = "";
            idproduit = 0;
            price = 0.00f;
            color = "";
            sNom = "";
            txtNom.Text = String.Empty;
            txtidproduct.Text = String.Empty;
            txtprice.Text = String.Empty;
            cmbcolor.Refresh();
            
        }

        private void btnSeeProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show(products[0].ToString());
        }
    }
}
