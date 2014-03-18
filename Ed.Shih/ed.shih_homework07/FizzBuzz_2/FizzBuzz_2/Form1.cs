﻿using System;
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
        private FizzBuzzCalculator _fizzBuzzCalculator = new FizzBuzzCalculator();
        
        public Form1()
        {
            InitializeComponent();
            _fizzBuzzCalculator = new FizzBuzzCalculator(2,3,5);
            fizzDivField.Text = "2";
            buzzDivField.Text = "3";
            bimDivField.Text = "5";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FizzButton1Click(object sender, EventArgs e)
        {
            int maxValue = GetMaxValue();
            if (maxValue < 1)
            {
                output.Text = @"Please enter an integer for Max Value.";
                return;
            }

            output.Text = @"Calculating FizzBuzzBim from 1 to " + MaxValue.Text;

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

        private void NewCalc_Click(object sender, EventArgs e)
        {
            // Make new FizzBuzzBim
            int fizzDiv = GetIntValue(fizzDivField.Text);
            int buzzDiv = GetIntValue(buzzDivField.Text);
            int bimDiv = GetIntValue(bimDivField.Text);
            if (fizzDiv <= 0 || buzzDiv <= 0 || bimDiv <= 0)
            {
                output.Text = @"Fizz, Buzz, and Bim must all be an integers";
            }
            else
            {
                output.Text = @"Ready to calculate new FizzBuzzBim.";
                _fizzBuzzCalculator = new FizzBuzzCalculator(fizzDiv, buzzDiv, bimDiv);
            }
       
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
