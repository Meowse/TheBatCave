using System;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        private readonly FizzBuzz _fizzbuzz = new FizzBuzz();
        private int _maxValue;
        private string result;

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
            if (_maxValue < 1)
            {
                displayNumberTextbox.Text = "Maximum value has to be greater then 1";
            }

            string[] numbers = _fizzbuzz.Count(_maxValue);
            for (int i = 1; i < _fizzbuzz.Count(_maxValue).Length; i++)
            {
                displayNumberTextbox.Text += numbers[i] + Environment.NewLine;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
