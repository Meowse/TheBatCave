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
        string oneTwoThree = string.Format("one two three");

        int x = 30;
        int y = 15;

        public Form1()
        {
            InitializeComponent();
            output1.Text = "Hello world";
            output2.Text = oneTwoThree;
            output3.Text = Convert.ToString(x + y);
            output4.Text = @"""""""";
            output5.Text = @"\\\\";
            output6.Text = @"""\"""""; //  "\"" (for reference)
            output7.Text = @"""\""""""\\\""\""""";       // "\"""\\\"\"" (for reference)
        }
    }
}
