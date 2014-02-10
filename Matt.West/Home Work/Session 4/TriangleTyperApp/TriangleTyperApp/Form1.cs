using System;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public partial class Form1 : Form
    {
        readonly InputValidations _validations = new InputValidations();
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

            string validateInput = _validations.GetInputValidations(sideA, sideB, sideC);
            if (validateInput != "ValidInput")
            {
                triangleTypeDisplay.Text = validateInput;
            }
            else
            {
                string triangleType = _calculator.GetTriangleType(sideA, sideB, sideC);
                triangleTypeDisplay.Text = triangleType;
            }
            

        }
    }
}
