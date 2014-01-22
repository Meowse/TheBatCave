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
            String Output2 = "one two three";
            int Output3 = 45;
            String Output4 = "\"\"\"\"";
            String Output5 = "\\\\\\\\";
            String Output6 = "\"\\\"\"";
            String Output7 = "\"\\\"\"\"\\\\\\\"\\\"\"";

            output1.Text = Output1;
            output2.Text = Output2;
            output3.Text = Output3.ToString();
            output4.Text = Output4;
            output5.Text = Output5;
            output6.Text = Output6;
            output7.Text = Output7;

        }
    }
}
