using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class
{
    class Bonjour
    {
        public Bonjour()
        {
            MessageBox.Show("New Object!");
        }
        public Bonjour(string msg)
        {
            MessageBox.Show(msg);
        }
        public Bonjour(string msg, string fname)
        {
            MessageBox.Show(msg + " " + fname);
        }
    }
}
