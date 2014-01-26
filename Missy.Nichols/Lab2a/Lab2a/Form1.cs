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
            int x = 15;
            int y = 15;
            int z = 15;

            InitializeComponent();
            output1.Text = "Hello world";
            output2.Text = string.Format("{0} {1} {2}", "one", "two", "three");
            output3.Text = (x + y + z).ToString();
            output4.Text = @"""""""";
            output5.Text = @"\\\\";
            output6.Text = @"""\""""";
            output7.Text = @"""\""""""\\\""\""""";
        }
    }
}