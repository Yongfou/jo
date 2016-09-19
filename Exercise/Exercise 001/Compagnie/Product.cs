using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compagnie
{
    class Product
    {
        public int Idproduct { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public List<string> Listcolor { get; set; } = new List<string>();
        public List<string> ListName { get; set; } = new List<string>();
        public Product(int idproduct, string name, double price, string color)
        {
            Idproduct = idproduct;
            Name = name;
            Price = price;
            Color = color;
            Listcolor.Add("Blue");
            Listcolor.Add ("Black");
            Listcolor.Add("White");
        }
        public void AddColor (string color)
        {
            Listcolor.Add(color);
        }
        public void ListAllProducts() //(string name)
        {
            
            //MessageBox.Show(listName);
        }
        public void ViewProduct()
        {
            MessageBox.Show(Idproduct + "\n" + Name + "\n" + Price.ToString("0.00")+ "$" + "\n" + Color);
        }
    }
}
