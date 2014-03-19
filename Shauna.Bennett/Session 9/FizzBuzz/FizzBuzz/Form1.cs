using System;
using System.Windows.Forms;

namespace FizzBuzzBim
{
    public partial class Form1 : Form
    {
        private FizzBuzzCalculator _fizzBuzzBimCalculator;

        public Form1()
        {
          //  _fizzBuzzBimCalculator = fizzBuzzBimCalculator;
            InitializeComponent();
            _fizzBuzzBimCalculator = new FizzBuzzBimCalculator(2, 3, 5);
            fizzDivisorField.Text = "2";
            buzzDivisorField.Text = "3";
            bimDivisorField.Text = "5";
        }

        private void fizzBuzzIt_Click(object sender, EventArgs e)
        {
            var maxValue = GetMaxValue();

            if (maxValue < 1)
            {
                outputLabel.Text = @"Please enter a positive integer.";
                return;
            }

            outputLabel.Text = @"Calculating FizzBuzz from 1 to " + maxValue;
            for (int i = 1; i <= maxValue; i++)
            {
                outputLabel.Text += Environment.NewLine + _fizzBuzzBimCalculator.Calculate(i);
            }
        }

        private int GetMaxValue()
        {
            try
            {
                return Convert.ToInt32(maxValueField.Text);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        private int GetIntValue(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                return 0;
            }
        }

        private void newFizzBuzzerButton_Click(object sender, EventArgs e)
        {
            int fizzDivisor = GetIntValue(fizzDivisorField.Text);
            int buzzDivisor = GetIntValue(buzzDivisorField.Text);
            _fizzBuzzBimCalculator = new FizzBuzzCalculator(fizzDivisor, buzzDivisor);
        }
    }
}
