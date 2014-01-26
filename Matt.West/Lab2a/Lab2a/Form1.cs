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

        private void Form1_Load(object sender, EventArgs e)
        {
            String Output1 = "Hello World";
            String S1 = "one";
            String S2 = "two"; 
            String S3 = "three";
            int Output3 = 45;
            String Output4 = "\"\"\"\"";
            String Output5 = "\\\\\\\\";
            String Output6 = "\"\\\"\"";
            String Output7 = "\"\\\"\"\"\\\\\\\"\\\"\"";

            output1.Text = Output1;
            output2.Text = string.Format("{0} {1} {2}", S1,S2,S3);
            output3.Text = Output3.ToString();
            output4.Text = Output4;
            output5.Text = Output5;
            output6.Text = Output6;
            output7.Text = Output7;

        }
    }
}
