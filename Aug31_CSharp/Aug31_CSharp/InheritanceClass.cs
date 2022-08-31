using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug31_CSharp
{
    public class InheritanceClass : SumClass
    {
       
            public override int Add(int a, int b)
            {
                Console.WriteLine("The sum is:");
                return a + b;
            }
    }
}
