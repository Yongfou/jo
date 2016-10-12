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
    public partial class DeletePerson : Form
    {
        public DeletePerson()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Id = (txtDeletePerson.Text);
            GlobalVar.persons.Remove(GlobalVar.persons.Find(x => x.Numberclient == Id));
        }
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
