using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Properties
{
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public Person(string firstname, string lastname, int age = 18)
        {
            Fname = firstname;
            Lname = lastname;
            Age = age;
        }
    }
}
