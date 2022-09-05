using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_Sept05
{
    public class Admin
    {
        public string id { get; set; }
        public string pass { get; set; }
        public string f_name { get; set; }
        public void showmenu()
        {
            Console.WriteLine("Press 1 for Add Franchise\n  Press 2 for Franchise record\n  Press 3 for sales record");
        }

    }
}
