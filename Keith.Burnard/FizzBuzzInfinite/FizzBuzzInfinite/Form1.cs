using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace FizzBuzzInfinite
{
    public partial class Form1 : Form
    {
        List<FizzBuzzObject> _listOfFizzBuzzObjects = new List<FizzBuzzObject>();
        readonly FizzBuzzCalculator _fizzBuzzCalculator = new FizzBuzzCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            var fizzBuzzObjectToAdd = new FizzBuzzObject();
            SetFizzBuzzValues(fizzBuzzObjectToAdd);
            ResetForm();
        }

        private void SetFizzBuzzValues(FizzBuzzObject fizzBuzzObjectToAdd)
        {
            int result;
            if (int.TryParse(tbDevisor.Text, out result))
            {
                if (int.Parse(tbDevisor.Text) > 0)
                {
                    fizzBuzzObjectToAdd.Denominator = int.Parse(tbDevisor.Text);
                    fizzBuzzObjectToAdd.Message = tbMessage.Text;
                    _listOfFizzBuzzObjects.Add(fizzBuzzObjectToAdd);
                }
                else
                {
                    MessageBox.Show(@"The Denominator needs to be a positive whole number");
                }
            }
            else
            {
                MessageBox.Show(@"The Denominator needs to be a positive whole number");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _listOfFizzBuzzObjects = new List<FizzBuzzObject>();
            ResetForm();
        }

        private void ResetForm()
        {
            tbDevisor.Text = "";
            tbMessage.Text = "";
            tbDevisor.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFizzBuzz_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_fizzBuzzCalculator.Calculate(_listOfFizzBuzzObjects, 15));
        }
    }
}
