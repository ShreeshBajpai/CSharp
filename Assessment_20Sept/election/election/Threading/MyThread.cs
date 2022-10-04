using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace election.Threading
{
    class MyThread
    {
        public static void PrintDotAnimation(int timer = 10)
        {
            for (int i = 0; i < timer; i++)
            {
                Console.Write(".");
                Thread.Sleep(5);
            }

        }
        public void thread1()
        {
            for (int i = 0; i < 7; i++)
            {

                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
            Console.WriteLine("File Created Successfully");
        }
    }
}
