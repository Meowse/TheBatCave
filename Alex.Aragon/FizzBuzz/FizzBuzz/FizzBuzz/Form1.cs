using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public int[] CountFromToWithForLoop(int min, int max)
        {
            int length = max - min + 1;
            int[] result = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                result[i] = min + i;
            }
            return result;
        }


        public String[] FizzBuzz () {
            /*FizzBuzz: print out the numbers from 1 to N, one per line. BUT:

            ii. If a number is divisible by 3, print out “Fizz” instead of the number. AND:

            iii. If a number is divisible by 5, print out “Buzz” instead of the number. 

            EXCEPT:

            iv. If a number is divisible by both 3 and 5, print out “FizzBuzz” instead of the 

            number.

            v. And -- create a brand new Visual Studio solution, including a separate 

            project to hold your tests.*/
            string[] result = new string[] {};
            int[] intArray = CountFromToWithForLoop(1, 3);
            for(int i=0; i < intArray.Length; i++ )
            {
                if (intArray[i] % 3 == 0 && intArray[i] % 5 == 0)
                {
                    result[i] = intArray[i] + "FizzBuzz";
                }
                else if (intArray[i]%3 == 0){
                    result[i] = intArray[i] + "Fizz";
                }
                else if (intArray[i]%5 == 0)
                {
                    result[i] = intArray[i] + "Buzz";
                }
                else
                //System.Console.WriteLine(intArray[i]);
                result[i] = intArray[i].ToString();
            }
            return result;

        }

    }
}
