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
            //Output1
            string A = "Hello World";
            output1.Text = A;

            //Output2
            string orderNums = "{0} "+"{1} "+"{2} ";
            string x = "one";
            string y = "two";
            string z = "three";
            output2.Text = string.Format(orderNums,x,y,z);

            //Output3
            int num1 = 9;
            int num2 = 5;
            output3.Text = (num1*num2).ToString();

            //Output4
            string quote1 = "\"";
            string quote2 = "\"";
            string quote3 = "\"";
            output4.Text = quote1 + quote2 + quote3;

            //Output5
            string backslash = "\\" + "\\" + "\\" +"\\";
            output5.Text = backslash;

            //Output6
            string backslashQuote = "\"\\\"\"";
            output6.Text = backslashQuote;

            //Output7
            string quoteBackSlash = "\"\\\"\"\"\\\\\\\"\\\"\"";
            output7.Text = quoteBackSlash;

        }
    }
}
