using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;

namespace Lab2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            output1.Text = "Hello world";
            string value1 = "one";
            string value2 = "two";
            string value3 = "three";
            output2.Text = string.Format("{0} {1} {2}",value1,value2,value3);
            int x = 9;
            int y = 5;
            output3.Text = (x*y).ToString();
            output4.Text = @"""""""";
            output5.Text = "\\\\\\\\";
            output6.Text = @"""\""""";
            output7.Text = @"""\""""""\\\""\""""";
        }
    }
}
