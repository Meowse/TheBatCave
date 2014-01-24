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

            string HelloWorld = "Hello World";
            output1.Text = HelloWorld;

            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            string space = " ";
            output2.Text = string.Format(value1 + " " + value2 + space + value3);

            int x = 5;
            int y = 8;
            output3.Text = (x * y + x).ToString();

            output4.Text = "\"\"\"";

            output5.Text = "\\\\\\\\";

            output6.Text = "\"\\\"\"";

            output7.Text = "\"\\\"\"\"\\\\\\\"\\\"\"";

        }

       
    }
}
