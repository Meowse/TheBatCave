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
        string oneValue = "one";
        string twoValue = "two";
        string threeValue = "three";

        int x = 30;
        int y = 15;

        public Form1()
        {
            InitializeComponent();
            output1.Text = "Hello world";
            output2.Text = string.Format("{0} {1} {2}", oneValue, twoValue, threeValue);
            output3.Text = Convert.ToString(x + y);
            output4.Text = @"""""""";
            output5.Text = @"\\\\";
            output6.Text = @"""\"""""; //  "\"" (for reference)
            output7.Text = @"""\""""""\\\""\""""";       // "\"""\\\"\"" (for reference)
        }
    }
}
