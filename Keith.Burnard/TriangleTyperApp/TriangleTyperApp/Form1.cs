using System;
using System.Windows.Forms;

namespace TriangleTyperApp
{
    public partial class Form1 : Form
    {
        private readonly ValidatingCalculator _validatingCalculator = new ValidatingCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void typeItButton_Click(object sender, EventArgs e)
        {
            string sideA = sideAField.Text;
            string sideB = sideBField.Text;
            string sideC = sideCField.Text;
            
            var message = _validatingCalculator.GetValidatedTriangleType(sideA, sideB, sideC);

            triangleTypeDisplay.Text = message;

            
        }

    }
}
