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
        }

        private void output1_Click(object sender, EventArgs e)
        {
            output1.Text = ("Hello World");

        }

        private void output2_Click(object sender, EventArgs e)
        {
            string S1 = "one";
            string S2 = "two";
            string S3 = "three";
            output2.Text = string.Format("{0},{1},{2}", S1,S2,S3);

        }

        private void output3_Click(object sender, EventArgs e)
        {
            int x = 540;
            int y = 12;
            int answer = (x/y);
            string strAnswer = answer.ToString();
            output3.Text = strAnswer;

        }

        private void output4_Click(object sender, EventArgs e)
        {
            output4.Text="\"\"\";
        }

        private void output5_Click(object sender, EventArgs e)
        {
            output5.Text = "\\\\";

        }

        private void output6_Click(object sender, EventArgs e)
        {
            output6.Text = "\"\\\"\"";

        }

        private void output7_Click(object sender, EventArgs e)
        {
           output7.Text ="\"\\\"\"\"\\\\\\"\\\"\"";
        }
    }
}
