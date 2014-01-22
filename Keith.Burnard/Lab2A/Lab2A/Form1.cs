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

        private void btnDoTheThing_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";

            string One_STRING = "One";
            string Two_STRING = "Two";
            string Three_STRING = "Three";
            lblOneTwoThree.Text = string.Format("{0} {1} {2}", One_STRING, Two_STRING, Three_STRING);

            int FortyFive_INT = 45;
            lbl45.Text = FortyFive_INT.ToString();

            lblJustQuotes.Text = "\"\"\"";

            lblJustBackslashes.Text = "\\\\\\\\";

            lblOneBackslash.Text = "\"\\\"\"";

            lblManyBackslash.Text = "\"\\\"\"\"\\\\\\\"\\\"\"";
        }
    }
}
