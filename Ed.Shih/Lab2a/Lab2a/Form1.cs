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
            
            string A = "one";
            string B = "two";
            string C = "three";
            output2.Text = A + " " + B + " " + C;

            int x = 5;
            int y = 9;
            output3.Text = (y * 4 + x + 4).ToString();

            output4.Text = @"""""""";

            output5.Text = @"\\\\";

            string m = @"\";
            string n = @"""";
            output6.Text = n + m + n + n;

            output7.Text = n + m + n + n + n + m + m + m + n + m + n + n;






        }
    }
}
