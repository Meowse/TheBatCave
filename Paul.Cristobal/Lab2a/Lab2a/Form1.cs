using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //output 1
            String word1 = "Hello";
            String word2 = "world";
            output1.Text = word1 + " " + word2;

            //output 2
            string newString;
            newString = string.Format("{0} {1} {2}", "one", "two", "three");
            System.Console.WriteLine(newString);
            output2.Text = newString;

            //output 3
            int x = 9;
            int y = 5;
            output3.Text = (x * y).ToString();

            //output 4
            const String TRIPLEQUOTE = @"""""";
            Console.WriteLine(TRIPLEQUOTE);
            output4.Text = TRIPLEQUOTE;

            //output 5
            const String QUADBACKSLASH = @"\\\\";
            Console.WriteLine(QUADBACKSLASH);
            output5.Text = QUADBACKSLASH;

            //output 6
            const String SingleBackDouble = @"""\""""";
            Console.WriteLine(SingleBackDouble);
            output6.Text = SingleBackDouble;

            //output 7. This method is much easier. 
            output7.Text = "\"\\\"\"\"\\\\\\\"\\\"\"";


        }
    }
}