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

            string hello = "Hello World";
            output1.Text = hello; 
            
            string one = "one";
            string two = "two";
            string three = "three";
            string space = " ";
            string stringoutput2 = string.Format("{0}{1}{2}{3}{4}",one,space,two,space,three);
            output2.Text = stringoutput2;

            int x = 9;
            int y = 5;
            int z = x * y;
            output3.Text = z.ToString();  
            
            string doublequote = "\"";
            output4.Text = doublequote + doublequote + doublequote;

            string slash = "\\";
            output5.Text = slash + slash + slash + slash;

            output6.Text = doublequote + slash + doublequote + doublequote;

            output7.Text = doublequote + slash + doublequote + doublequote + doublequote + slash + slash
                + slash + doublequote + slash + doublequote + doublequote;


        }

        private void output2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
