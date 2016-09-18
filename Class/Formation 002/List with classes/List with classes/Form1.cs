using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_with_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            List<Person> persons = new List<Person>();
            Person pers1 = new Person ("Jonathan", "Gagne");

            List<string> hobis = new List<string>();
            Person pers2 = new Person("Sebatien", "Paquet", 27);

            persons.Add(pers1);
            persons.Add(pers2);

            Person sebas = persons[1];

            sebas.AddHobis("Peche");
            sebas.AddHobis("Climbing");
            sebas.AddHobis("Vue");

            sebas.DelHobis("Peche");

            MessageBox.Show(sebas.Hobis[0]);
            MessageBox.Show(sebas.Hobis[1]);

            sebas.isJunior();

            MessageBox.Show(sebas.Fname + " " + sebas.Lname);
        }
    }
}
