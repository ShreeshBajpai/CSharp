using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp
{
    public class Teacher
    {
        public int Tid { get; set; }
        public string Tname { get; set; }
        public void show()
        {
            Console.WriteLine("ID: " + Tid + "/ Name : " + Tname);
        }
    }
}
