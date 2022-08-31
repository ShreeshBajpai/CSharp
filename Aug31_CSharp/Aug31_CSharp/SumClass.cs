using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug31_CSharp
{
    public class SumClass
    {
        public virtual int Add(int a, int b)
        {
            return a + b;
        }

        // adding three values.
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
