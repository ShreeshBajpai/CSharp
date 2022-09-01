using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesPractice
{
    public class DelegatesOperations
    {
        //defining delegates of functions
        public delegate void addDelegate(int a, int b);
        public delegate string greetingsDelegate(string name);
        //defining delegates
        public delegate double Addnum1delegate(int x, float y, double z);   //func generic delegate
        public delegate void Addnum2delegate(int x, float y, double z);     //action generic delegate
        public delegate bool checkLendelegate(string name);                 //predicate generic delegate



        public static void Add(int x, int y)
        {
            Console.WriteLine(@"The sum of {0} and {1} is {2}", x, y, (x + y));            
        }
        public static string Greetings(string name)
        {
            return "Hello " + name;
        }

        //--------------------generic delegates-------------------

        //returning function
        public static double Addnumber1(int x, float y, double z)
        {
            return x + y + z;
        }
        //printing function
        public static void Addnumber2(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }
        //conditional returning functions
        public static bool checkLength(string name)
        {
            if (name.Length > 5)
            {
                return true;
            }
            return false;
        }
    }
}
