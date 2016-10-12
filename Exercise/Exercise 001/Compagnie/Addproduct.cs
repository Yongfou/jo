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
        public static TextBox TxtNom { get; set; }
        public static TextBox TxtIdproduct { get; set; }
        public static TextBox TxtPrice { get; set; }
        public static ComboBox CmbColor { get; set; }
        public static DataGridView MyGrid { get; set; }
        public static TextBox TxtN { get; set; }

        public Addproduct()
        {
            InitializeComponent();
            TxtNom = txtNom;
            TxtIdproduct = txtidproduct;
            TxtPrice = txtprice;
            CmbColor = cmbcolor;
            MyGrid = myGrid;
            TxtN = txtn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Product();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
