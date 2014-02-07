using System;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public partial class Form1 : Form
    {
        readonly TriangleTypeCalculator _calculator = new TriangleTypeCalculator();
        private readonly InputValidation _inputValidation = new InputValidation();

        public Form1()
        {
            InitializeComponent();
        }

        private void typeItButton_Click(object sender, EventArgs e)
        {
            string sideA = sideAField.Text;
            string sideB = sideBField.Text;
            string sideC = sideCField.Text;

            string message = _inputValidation.TestInputValues(sideA, sideB, sideC);

            if (message == "Good")
            {
                string triangleType = _calculator.GetTriangleType(sideA, sideB, sideC);
                triangleTypeDisplay.Text = triangleType;
            }
            else
            {
                triangleTypeDisplay.Text = message;
            }

            
        }

        
    }
}
