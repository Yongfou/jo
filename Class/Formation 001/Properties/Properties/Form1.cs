﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Person pers = new Person("Sébastien" , "Paquet",22);

            MessageBox.Show(pers.Age.ToString(),"test");
            new Random();
        }
    }
}
