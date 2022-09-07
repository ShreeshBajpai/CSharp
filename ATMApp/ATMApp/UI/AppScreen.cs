using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMApp.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //Clears Console
            Console.Clear();
            //Sets the title
            Console.Title = "My ATM App";
            //Sets the text color or foreground color to white
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------!!!Welccome to My ATM App!!!---------------");
            Console.WriteLine("Please insert your ATM Card. \n");
            Console.WriteLine("Note: The actual machine will accept and validate the card.");
            Utility.PressEnterToContinue();
        }

        
    }
}
