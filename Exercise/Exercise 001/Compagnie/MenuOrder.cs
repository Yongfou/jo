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
    public partial class MenuOrder : Form
    {
        public MenuOrder()
        {
            InitializeComponent();
        }

        private void btnListAllOrders_Click(object sender, EventArgs e)
        {
            GlobalVar.listallorders.Show();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            GlobalVar.vieworder.Show();
        }

        private void btnAddorder_Click(object sender, EventArgs e)
        {
            GlobalVar.addorder.Show();
        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {
            GlobalVar.deleteorder.Show();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            GlobalVar.editorder.Show();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
