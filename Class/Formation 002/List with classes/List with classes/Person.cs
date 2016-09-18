using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_with_classes
{
    class Person
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }
        public List<string> Hobis { get; set; } = new List<string>();

        public Person(string firstname, string lastname, int age = 18, List<string> hobis = null)
        {
            Fname = firstname;
            Lname = lastname;
            Age = age;
        }

        public void AddHobis(string hobis)
        {
            Hobis.Add(hobis);
        }

        public void DelHobis(string hobis)
        {
            Hobis.Remove(hobis);
        }

        public void isJunior()
        {
            Fname += " Jr.";
        }
    }
}
