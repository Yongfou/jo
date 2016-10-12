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
    public partial class Allproducts : Form
    {
        public Allproducts()
        {
            InitializeComponent();
        }

        private void Allproducts_Load(object sender, EventArgs e)
        {
            myGrid.DataSource = GlobalVar.products.ToList();
        }
    }
}
