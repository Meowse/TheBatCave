using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            public string FizzBuzz(int from, int to)
                {
                    int @from;
                    int @to;
                    for (int i = from; i <= to; i++)
                    {
                        if (i%3 == 0 && i%5 == 0)
                            return "FIZZBUZZ\n";
                        if (i%3 == 0)
                            return "FIZZ\n";
                        if (i%5 == 0)
                           return "BUZZ\n";
                        else
                           return i.toString();
                    }
                    return null;
                }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
