using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace NotJustHelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("You Clicked Me!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Probably 4");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            //string MyString = textBox1.Text;


        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = textBox1.Text;
                textBox1.Clear();
            }
            else
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = textBox2.Text;
                    textBox2.Clear();
                }
            }

        }

    }


}
