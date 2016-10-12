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
    public partial class ViewPerson : Form
    {
        public ViewPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Id = (txtnumberclient.Text);
            MessageBox.Show(GlobalVar.persons.Find(x => x.Numberclient == Id).ToString());
           
        }
    }
}
