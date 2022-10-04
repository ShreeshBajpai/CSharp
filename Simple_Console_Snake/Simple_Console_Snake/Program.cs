using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Console_Snake
{
    class Snake
    {
        int height = 20;
        int width = 30;
        public void WriteBoard()
        {
            Console.Clear();
            for (int i = 1; i <= (width+2); i++)
            {
                Console.SetCursorPosition(i,1);
                Console.Write("-");
            }
        }
        static void Main(string[] args)
        {

        }
    }
}
