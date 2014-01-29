using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVariables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int x = 3;
            int y = 7;
            x = 4;
            output.Text = (x * y).ToString();

            y = null;
            x = "4";
            String x = "4";
            String z = 13;

            output.Text = (x * y).ToString();

//            String firstName = "Mickey";
//            String space = " ";
//            String middleInitial = "D";
//            String lastName = "Phoenix";

//            firstName = "Eva-Lise";
//            middleInitial = "";
//            lastName = "Carlstrom";

//            String iHateYou = @"This is""a special""kind of string.";

            // Display this text on the screen: ""Hello\"\"\\"

//            output.Text = firstName + space + lastName;
//            output.Text = firstName + (" " + middleInitial + " ") + lastName + ": " + iHateYou;
        }
    }
}
