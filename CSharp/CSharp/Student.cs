using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public void show()
        {
            Console.WriteLine("ID: " + Sid+ "Name : "+ Sname);
        }
    }
    

}
