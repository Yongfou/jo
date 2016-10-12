using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compagnie
{
    public static class GlobalVar
    {
        public static ViewProduct viewproduct = new ViewProduct();
        public static Addproduct addproduct = new Addproduct();
        public static DeleteProduct deleteproduct = new DeleteProduct();
        public static EditProduct editproduct = new EditProduct();
        public static Allproducts allproduct = new Allproducts();
        public static MenuProduct menuproduct = new MenuProduct();
        public static List<Product> products = new List<Product>();
        public static List<Order> orders = new List<Order>();
        public static Addperso addperso = new Addperso();
        public static MenuPerson menuperson = new MenuPerson();
        public static List<int> idclients = new List<int>();
        public static List<Person> persons = new List<Person>();
        public static ListAllPersons listallpersons = new ListAllPersons();
        public static ViewPerson viewperson = new ViewPerson();
        public static DeletePerson deleteperson = new DeletePerson();
        public static EditPerson editperson = new EditPerson();
        public static ListAllOrders listallorders = new ListAllOrders();
        public static Form2 vieworder = new Form2();
        public static AddOrder addorder = new AddOrder();
        public static DeleteOrder deleteorder = new DeleteOrder();
        public static EditOrder editorder = new EditOrder();
        public static MenuOrder menuorder = new MenuOrder();
       // public static List<>
    }
}
