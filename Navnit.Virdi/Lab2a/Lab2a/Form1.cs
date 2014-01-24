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

        private void button1_Click(object sender, EventArgs e)
        {
            LBLHelloworld.Text = "Hello world";
            LBLonetwothree.Text = string.Format ("one two three");
            int x = 5;
            int y = 9;
            LBL45.Text =(x * y).ToString();
            LBLtwoquotes.Text = "\"\"\"";
            LBLfourbackslashes.Text = "\\\\\\\\";
            LBLonequotebackslash.Text = "\"\\\"\"";
            LBLonequoteonebackslashthreequot.Text ="\"\\\"\"\"\\\\\\\"\\\"\""; 
           




            

            
           

        }

        private void LBL45_Click(object sender, EventArgs e)
        {

        }

        private void LBLtwoquotes_Click(object sender, EventArgs e)
        {

        }
    }

}
