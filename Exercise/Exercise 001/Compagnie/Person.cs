using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compagnie
{
    public class Person
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public string Numberclient { get; set; }

        public Person( )
        {
            this.FName = Addperso.Txtfirstname.Text;
            this.LName = Addperso.Txtlastname.Text;
            this.Numberclient =(Addperso.LblNumberclient.Text);
            GlobalVar.persons.Add(this);
            Addperso.gridListClient.DataSource = GlobalVar.persons.ToList();
           
        }
        public override string ToString()
        {
            return Numberclient + "\n" + FName + "\n" + LName ;
        }
        public void listpersonne()
        {
            Addperso.gridListClient.DataSource = GlobalVar.persons.ToList();
        }

    }   
}
