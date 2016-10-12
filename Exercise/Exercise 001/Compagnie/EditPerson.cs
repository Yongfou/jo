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
    public partial class EditPerson : Form
    {
        public EditPerson()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string Id = (txtID.Text);
            Person p = new Person();
            p = (GlobalVar.persons.Find(x => x.Numberclient == Id));
            txtfirstname.Text = p.FName;
            txtlastname.Text = p.LName;
            lblNumberclient.Text = p.Numberclient.ToString();          
        }

    }
}
