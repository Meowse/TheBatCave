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
            string sideA = sideAField.Text;
            string sideB = sideBField.Text;
            string sideC = sideCField.Text;

            if (InputValid(sideA, sideB, sideC))
            {
                string triangleType = _calculator.GetTriangleType(sideA, sideB, sideC);
                triangleTypeDisplay.Text = triangleType;
            }

            
        }

        private bool InputValid(string sideA, string sideB, string sideC)
        {
            int sideAInt;
            int sideBInt;
            int sideCInt;
            
            if (!int.TryParse(sideA, out sideAInt))
            {
                triangleTypeDisplay.Text = "Input must be a positive integer";
                return false;
            }
            if (!int.TryParse(sideB, out sideBInt))
            {
                triangleTypeDisplay.Text = "Input must be a positive integer";
                return false;
            }
            if (!int.TryParse(sideB, out sideBInt))
            {
                triangleTypeDisplay.Text = "Input must be a positive integer";
                return false;
            }



            return true;

        }
    }
}
