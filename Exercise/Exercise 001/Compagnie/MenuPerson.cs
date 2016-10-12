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
    public partial class MenuPerson : Form
    {
        public MenuPerson()
        {
            InitializeComponent();
        }

        private void btnAddperson_Click(object sender, EventArgs e)
        {
            GlobalVar.addperso.Show();
        }

        private void btnListAllPersons_Click(object sender, EventArgs e)
        {
            GlobalVar.listallpersons.Show();
        }

        private void btnViewPersons_Click(object sender, EventArgs e)
        {
            GlobalVar.viewperson.Show();
        }

        private void btnDelProduct_Click(object sender, EventArgs e)
        {
            GlobalVar.deleteperson.Show();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            GlobalVar.editperson.Show();
        }

        private void btnAddPerson_Click_1(object sender, EventArgs e)
        {
            GlobalVar.addperso.Show();
        }
    }
}
