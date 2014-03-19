using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz2
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Enter input for bim:"); 
            var line = Console.ReadLine(); 

            
            int value;
            int.TryParse(line, out value);

         

            for (int i = 0; i < 100; i++)
            {

                if (((i % 3) == 0) && ((i % 5) == 0))
                {
                    Console.WriteLine("fizzbuzz");


                }
                
               
                else if (((i % 3) == 0) && ((i % 5) == 0) && ((i % value) == 0))
                {
                    Console.WriteLine("fizzbuzzbim");


                }

                
                else if ((i % 3) == 0)
                {
                    Console.WriteLine("fizz");
                    

                }

                else if ((i % 5) == 0)
                {
                    Console.WriteLine("buzz");
                   

                }

                else if ((i % value) == 0)
                {
                    Console.WriteLine("bim");


                }
                
                else Console.WriteLine(i);
                


            }


        }


    }


}


    
    

