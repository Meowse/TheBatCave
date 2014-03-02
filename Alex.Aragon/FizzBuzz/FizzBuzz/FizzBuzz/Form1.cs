using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzz;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        private readonly FizzBuzz _fizzbuzz = new FizzBuzz();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            output.Text = "";
            try
            {
                int userInput = Convert.ToInt32(input_txt.Text);
                String[] fizzBuzzArray =  _fizzbuzz.GetNums(userInput);
                output.Text += _fizzbuzz.ConvertStringArrayToString(fizzBuzzArray);
            }
            catch
            {
                output.Text = "Not a valid number.";
            }
            
        }

    }
}
