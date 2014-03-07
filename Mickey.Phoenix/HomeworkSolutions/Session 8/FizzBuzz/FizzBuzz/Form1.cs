using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fizzBuzzIt_Click(object sender, EventArgs e)
        {
            var maxValue = GetMaxValue();

            if (maxValue < 1)
            {
                outputLabel.Text = "Please enter a positive integer.";
                return;
            }

            outputLabel.Text = "Calculating FizzBuzz from 1 to " + maxValue;
            for (int i = 1; i <= maxValue; i++)
            {
                outputLabel.Text = outputLabel.Text + Environment.NewLine + i;
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
