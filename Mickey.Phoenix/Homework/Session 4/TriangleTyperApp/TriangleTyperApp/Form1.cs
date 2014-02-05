using System;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void typeItButton_Click(object sender, EventArgs e)
        {
            TriangleTypeCalculator calculator = new TriangleTypeCalculator();
            string sideA = sideAField.Text;
            string sideB = sideBField.Text;
            string sideC = sideCField.Text;
            string triangleType = calculator.GetTriangleType(sideA, sideB, sideC);
            triangleTypeDisplay.Text = triangleType;
        }
    }
}
