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
//  row 1: Hello World
            string hello = "Hello World";
            output1.Text = hello;

// row 2: one two three
            string a = "one";
            string b = "two";
            string c = "three";
            string d = " ";
            string full = string.Format("{0}{1}{2}{3}{4}", a, d, b, d, c);
            output2.Text = full;

// row 3: 45
            int x = 5;
            int y = 9;
            int z = x*y;
            output3.Text = z.ToString();

// row 4: ""
            string quotes = "\"\"\"";
            output4.Text = quotes;


// row 5: \\\\
            string backsplash = "\\\\\\\\";
            output5.Text = backsplash;

// row 6: \"\\
            string backandquote = "\"\\\"\"";
            output6.Text = backandquote;



// row 7: "\""\\\"\""
            string manybackandquote = "\"\\\"\"\"\\\\\\\"\\\"\"";
            output7.Text = manybackandquote;





            


         
        }

        private void output1_Click(object sender, EventArgs e)
        {
 //           MessageBox.Show("Hello World");
        }

        private void output2_Click(object sender, EventArgs e)
        {

        }
    }
}
