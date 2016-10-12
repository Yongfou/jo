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
    public partial class ListAllOrders : Form
    {
        public ListAllOrders()
        {
            InitializeComponent();
        }

        private void ListAllOrders_Load(object sender, EventArgs e)
        {
            GridOrders.DataSource = GlobalVar.persons.ToList();
        }
    }
}
