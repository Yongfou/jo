using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compagnie
{
    public class Product
    {
        public int Idproduct { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Quantité { get; set; }
        public Product()
        {
            this.Name = Addproduct.TxtNom.Text;
            this.Idproduct = Convert.ToInt32(Addproduct.TxtIdproduct.Text);
            this.Price = Convert.ToDecimal(Addproduct.TxtPrice.Text);
            this.Color = Addproduct.CmbColor.Text;
            this.Quantité = Convert.ToInt32(Addproduct.TxtN.Text);
            GlobalVar.products.Add(this);
            Addproduct.TxtNom.Text = "";
            Addproduct.TxtIdproduct.Text = "";
            Addproduct.TxtPrice.Text = "";
            Addproduct.CmbColor.Text = "";
            Addproduct.TxtN.Text = "";
            Addproduct.MyGrid.DataSource = GlobalVar.products.ToList();
        }
        
        public override string ToString()
        {
            return Idproduct + "\n" + Name + "\n" + Price.ToString("0.00") + "$" + "\n" + Color + "\n" + Quantité;
        }
    }
}
