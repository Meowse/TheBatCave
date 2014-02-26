using System;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        private readonly FizzBuzz _fizzbuzz = new FizzBuzz();
        private const int MinValue = 1;
        private int _maxValue;

        public Form1()
        {
            InitializeComponent();
        }

        public void CheckIfMaxValue (int max)
        {
            try
            {
                _maxValue = int.Parse(maxValueTextbox.Text);
            }
            catch (FormatException)
            {
                displayNumberTextbox.Text = "Input must be an integer";
            }
        }

        private void displayNumbers_Click(object sender, EventArgs e)
        {
            displayNumberTextbox.Clear();
            CheckIfMaxValue(_maxValue);
            if (MinValue > _maxValue)
            {
                displayNumberTextbox.Text = "Minimun value has to be less then maximum value";
            }

            string[] numbers = _fizzbuzz.Count(MinValue, _maxValue);
            for (int i = 1; i < _fizzbuzz.Count(MinValue, _maxValue).Length; i++)
            {
                displayNumberTextbox.Text += numbers[i] + Environment.NewLine;
            }
        }

        private void minValueTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
