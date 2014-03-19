using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float input1;

        private void FizzButton1_Click(object sender, EventArgs e)
        {
            input1 = Convert.ToInt32(Input1.Text);
            // need to look up how to get return to go into result box as string

            for (int i = 0; i <= input1; i++)
            {
                if (i%3 == 0 && i%5 == 0)
                    Console.WriteLine("FIZZBUZZ");
                if (i%3 == 0)
                    Console.WriteLine("FIZZ");
                if (i%5 == 0)
                    Console.WriteLine("BUZZ");
                else
                {
                    return Console.WriteLine(i.ToString);    
                }
            }

        }

        private void Input1_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
