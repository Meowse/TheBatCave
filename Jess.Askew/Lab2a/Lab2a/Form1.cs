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

        private void BTNcodeify_Click(object sender, EventArgs e)
        {
            LBLHelloWorld.Text = "Hello World";
            LBLonetwothree.Text = string.Format("one two three");
            int number = 45;
            LBLfortyfive.Text = number.ToString();
//               For some reason unknown to me, this didn't work when I used int x instead of int number, and it kept saying that int
//            couldn't be converted to tostring
            LBLtwodblquote.Text = "\"\"";
            LBLfourbackslash.Text = "\\\\\\\\";
            LBLquoteslashtwoquote.Text = "\"\\\"\"";
            LBLquoteslashtwoquotethreeslashthreequoteslashtwoquote.Text = "\"\\\"\"\"\\\\\\\"\\\"\"";




        }
    }
}
