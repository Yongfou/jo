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
    public partial class ListAllPersons : Form
    {
        public ListAllPersons()
        {
            InitializeComponent();
        }

        private void ListAllPersons_Load(object sender, EventArgs e)
        {
            GridClient.DataSource = GlobalVar.persons.ToList();
        }
    }
}
