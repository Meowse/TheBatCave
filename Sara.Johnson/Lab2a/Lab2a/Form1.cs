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

            output1.Text = "Hello world";

            string a = "one";
            string b = "two";
            string c = "three";
            string d = " ";
            string stringOutput2 = String.Format("{0}{1}{2}{3}{4}",a,d,b,d,c);
            output2.Text = stringOutput2;

            int x = 45;
            output3.Text = x.ToString();

            string quotes = "\"\"\"";
            output4.Text = quotes;

            string backslash = "\\\\\\\\";
            output5.Text = backslash;

            string backslashquote1 = "\"\\\"\"";
            output6.Text = backslashquote1;

            string backslashquote2 = "\"\\\"\"\"\\\\\\\"\\\"\"";
            output7.Text = backslashquote2;

        }
    }
}
