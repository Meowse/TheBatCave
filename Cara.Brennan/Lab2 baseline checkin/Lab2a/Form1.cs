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

            String HelloWorld = "Hello World";
            output1.Text = HelloWorld;

            String onetwothree = string.Format("one two three");
            output2.Text = onetwothree;

            int s = 1;
            int c = 40;
            output3.Text = (s*c).ToString();

           
            output4.Text = "\"\"\"";

            output5.Text = "\\\\\\\\";

            
            output6.Text = "\"\\\"\"";

            output7.Text = "\"\\\"\"\"\\\\\\\"\\\"\"";





        }
    }
}
