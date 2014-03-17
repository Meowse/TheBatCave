using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz_2
{
    public partial class Form1 : Form
    {
        private readonly FizzBuzzCalculator _fizzBuzzCalculator = new FizzBuzzCalculator();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FizzButton1Click(object sender, EventArgs e)
        {
            int maxValue = GetMaxValue();
            if (maxValue < 1)
            {
                output.Text = @"Please enter an integer.";
                return;
            }

            output.Text = @"Calculating FizzBuzz from 1 to " + MaxValue.Text;

            for (int i = 1; i <= maxValue; i++)
            {
                output.Text += Environment.NewLine + _fizzBuzzCalculator.Calculate(i);
            }
        }

        private int GetMaxValue()
        {
           
            try
            {
                return Convert.ToInt32(MaxValue.Text);
            }
            catch (FormatException)
            {
                return 0;
            }
        }
    }
}
