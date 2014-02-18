using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            //number 1
            output1.Text = ("Hello Mickey, Eva-Lise, and the rest of the world!");

            //number 2
            String numberTwo = ("one, two, three");
            output2.Text = numberTwo;

            //number 3
            int x = 25;
            int y = 20;
            int product = (x+y);
            string strProduct = product.ToString();
            output3.Text = strProduct;

            //number 4
            output4.Text = @"""""""";

            //number 5
            output5.Text = @"\\\\";

            //number 6
            output6.Text = "\"\\\"\"";

            //number 7
            output7.Text = "\"\\\"\"\"\\\\\\\"\\\"\"";
        }
    }
}