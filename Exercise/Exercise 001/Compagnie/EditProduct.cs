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
    public partial class EditProduct : Form
    {
        public EditProduct()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtNumberclient.Text);
            Product p = new Product();
            p = (GlobalVar.products.Find(x => x.Idproduct == Id));
            txtidproduct.Text = (p.Idproduct.ToString());
            txtNom.Text = p.Name;
            txtprice.Text = p.Price.ToString();
            cmbcolor.Text = p.Color;
        }
    }
}
