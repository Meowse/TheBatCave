using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Gale02
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("This goes to the debug window");
            Debug.WriteLine("To make this window visible use menu item");
            Debug.WriteLine("Debug\\Windows\\Output");

            int flavor = 0;
            int orangeStock = 3;
            int regularStock = 3;
            int lemonStock = 3;

            CanRack regularRack;
            regularRack = new CanRack();
            CanRack orangeRack;
            orangeRack = new CanRack();  
            CanRack lemonRack;
            lemonRack = new CanRack();
            while (flavor < 4)
            {
            Console.WriteLine("Select a flavor");
            Console.WriteLine("1 for Regular");
            Console.WriteLine("2 for Orange");
            Console.WriteLine("3 for Lemon");
            Console.WriteLine("4 to Exit");
           flavor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (flavor)
            {
                case 1:
                    Console.WriteLine("You entered {0}.", flavor);
                    regularRack.CanRackMethod();
                    regularStock = regularRack.Stock;
                    break;
                case 2:
                    Console.WriteLine("You entered {0}.", flavor);
                    orangeRack.CanRackMethod();
                    orangeStock = orangeRack.Stock;
                    break;
                case 3:
                    Console.WriteLine("You entered {0}.", flavor);
                    lemonRack.CanRackMethod();
                    lemonStock = lemonRack.Stock;
                    break;
                default:
            Console.WriteLine("Current Stock Levels");
            Console.WriteLine("Regular {0}", regularStock);
           Console.WriteLine("Orange {0}", orangeStock);
          Console.WriteLine("Lemon {0}", lemonStock);
                  Console.WriteLine("Bye!");
                    Console.ReadLine();
                    break;
            }
 
  }

    }
    }
}