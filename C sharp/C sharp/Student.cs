using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    public class Student
    {
        public int sid { get; set; }
        public string sname { get; set; }
    }
    public void show()
    {
        Console.WriteLine(sid+"/"+sname);
    }
}
