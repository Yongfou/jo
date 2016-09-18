using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            List<string> mylist = new List<string>();
            mylist.Add("test1");
            mylist.Add("test2");
            mylist.Add("test3");
            mylist.Add("test4");

            foreach (string value in mylist)
            {
                MessageBox.Show(mylist[i]);
                i++;
            }
        }
    }
}
