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
    public partial class MenuProduct : Form
    {

        public MenuProduct()
        {
            InitializeComponent();
        }

        private void btnListAllProducts_Click(object sender, EventArgs e)
        {
            GlobalVar.allproduct.Show();
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            GlobalVar.viewproduct.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            GlobalVar.addproduct.Show();
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            GlobalVar.deleteproduct.Show();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            GlobalVar.editproduct.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

      
    }
}
