using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Design
{
    public class Products : InterfaceProducts
    {
        public int p_id;
        public int c_id;
        public int p_price;
        public int p_quantity;

        public delegate string delegateProductName(string p_name);
        public static string ProductName(string p_name)
        {
            return p_name;
        }
        public void PInterface(string str)
        {
            Console.WriteLine("Enter Admin Name: ");
            str = Console.ReadLine();
            Console.WriteLine("Admin is : "+ str);
        }
    }
}
