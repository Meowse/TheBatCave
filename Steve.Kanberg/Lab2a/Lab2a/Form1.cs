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
            String hello = "Hello world";
            output1.Text = hello;

            output2.Text = String.Format("one two three");

            int x = 45;
            output3.Text = x.ToString();

            output4.Text = @"""""""";

            output5.Text = "\\\\\\\\";

            output6.Text = @"""\""""";

            output7.Text = @"""\""""""""\\\""\""""";
        }

        private void output1_Click(object sender, EventArgs e)
        {
            
        }

        private void output2_Click(object sender, EventArgs e)
        {
                
        }

        private void output3_Click(object sender, EventArgs e)
        {

        }

        private void output4_Click(object sender, EventArgs e)
        {

        }

        private void output5_Click(object sender, EventArgs e)
        {

        }

        private void output6_Click(object sender, EventArgs e)
        {

        }

        private void output7_Click(object sender, EventArgs e)
        {

        }
    }
}
