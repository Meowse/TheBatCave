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
            output2.Text = string.Format("one two three");
            int value1 = 40;
            int value2 = 5;
            int sum = value1+value2;
            output3.Text = string.Format("{0}", sum);
            output4.Text = @"""""""";
            output5.Text = @"\\\\";
            output6.Text = @"""\""""";
            output7.Text = @"""\""""\\\""\""""";
        }
    }
}
