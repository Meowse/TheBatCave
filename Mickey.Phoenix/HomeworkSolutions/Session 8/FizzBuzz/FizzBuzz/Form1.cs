using System;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        private readonly FizzBuzzCalculator _fizzBuzzCalculator = new FizzBuzzCalculator();

        public Form1()
        {
            InitializeComponent();
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
    }
}
