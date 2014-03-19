
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBizzBumFrodoBilboGandalf

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        while(int i =0, i <= 100, i++)
    {
        if (i%5 == 0 && i%3 == 0 && i > 0)
        {
            Console.Write("FizzBuzz");
        }
        else (i%3 == 0);
                {
                    Console.Write("Fizz");
                }
            else
        (i%5 == 0);
                {
                    Console.Write("Buzz");
                }


            }
        }
}
