using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzzInfinite
{
    public partial class Form1 : Form
    {
        List<FizzBuzzObject> _listOfFizzBuzzObjects = new List<FizzBuzzObject>();
        FizzBuzzCalculator _fizzBuzzCalculator = new FizzBuzzCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            FizzBuzzObject fizzBuzzObjectToAdd = new FizzBuzzObject();

            int result;
            if (int.TryParse(tbDevisor.Text, out result))
            {
                if (int.Parse(tbDevisor.Text)>0)
                {
                    fizzBuzzObjectToAdd.Denominator = int.Parse(tbDevisor.Text);
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

            fizzBuzzObjectToAdd.Message = tbMessage.Text;
            _listOfFizzBuzzObjects.Add(fizzBuzzObjectToAdd);
            tbDevisor.Text = "";
            tbMessage.Text = "";
            tbDevisor.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _listOfFizzBuzzObjects = new List<FizzBuzzObject>();
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
