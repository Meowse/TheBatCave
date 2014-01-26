using System;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Perfect ... Get to work then!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hopefully it will get better.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Have a beer and go back to bed.";
        }

    }
}
