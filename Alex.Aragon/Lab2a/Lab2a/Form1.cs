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
            String hello = "Hello World";
            output1.Text = hello;
            String onetwothree = string.Format("one two three"); 
            output2.Text = onetwothree;
            int varible3 = 45;
            output3.Text = varible3.ToString();
            String varible4 = "\"\"\"";
            output4.Text = varible4;
            String varible5 = "\\\\\\\\";
            output5.Text = varible5;
            String varible6 = "\"\\\"\"";
            output6.Text = varible6;
            String varible7 = "\"\\\"\"\"\\\\\\\"\\\"\"";
            output7.Text = varible7;
        }

    }
}
