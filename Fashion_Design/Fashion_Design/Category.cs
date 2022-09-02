using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_Design
{
    public class Category
    {
        public int c_id;
        public delegate string delegateCategoryName(string c_name);
        public static string Message(string c_name)
        {
            return c_name;
        }
    }
}
