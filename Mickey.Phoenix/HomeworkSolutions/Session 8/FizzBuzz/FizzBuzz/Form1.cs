using System;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        private FizzBuzzCalculator _fizzBuzzCalculator;

        public Form1()
        {
            InitializeComponent();
            _fizzBuzzCalculator = new FizzBuzzCalculator(3, 5);
            fizzDivisorField.Text = "3";
            buzzDivisorField.Text = "5";
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
                outputLabel.Text += Environment.NewLine + _fizzBuzzCalculator.Calculate(i);
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
            _fizzBuzzCalculator = new FizzBuzzCalculator(fizzDivisor, buzzDivisor);
        }
    }
}
