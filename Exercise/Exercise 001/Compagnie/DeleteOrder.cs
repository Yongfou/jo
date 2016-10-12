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
    public partial class DeleteOrder : Form
    {
        public DeleteOrder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Id =Convert.ToInt32 (txtDeleteOrder.Text);
            GlobalVar.orders.Remove(GlobalVar.orders.Find(x => x.Idorder == Id));
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
