using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compagnie
{
    public class Order
    {
        public int Idorder { get; set; }
       // public List<Person> OrderPersone { get; set; } 
        public List<Product> OrderProducts { get; set; } = new List<Product>();

        public decimal Total { get; set; }

        public Order(int idorder, List<Product> ordersproducts)
        {
            Idorder = idorder;
            OrderProducts = ordersproducts;
            Total = 0;
            foreach(Product p in OrderProducts)
            {
                Total += (Decimal)p.Price;
            }
        }

        public override string ToString()
        {
            return Total.ToString();
        }
    }
}
