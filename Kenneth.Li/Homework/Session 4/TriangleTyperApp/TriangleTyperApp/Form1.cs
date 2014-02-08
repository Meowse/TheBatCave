using System;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public partial class Form1 : Form
    {
        readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void typeItButton_Click(object sender, EventArgs e)
        {
            var sideA = sideAField.Text;
            var sideB = sideBField.Text;
            var sideC = sideCField.Text;
            var triangleType = _calculator.ConvertTriangleValuesToDecimal(sideA, sideB, sideC);
            triangleTypeDisplay.Text = triangleType;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
