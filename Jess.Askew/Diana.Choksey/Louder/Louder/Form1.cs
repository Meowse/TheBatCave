using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Louder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
	        MessageBox.Show("You're not loud enough, I can't hear you!");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What you say? You're still not loud enough, I can't hear you!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You just set a world record for being 110 decibels loud! Way to go!");
        }
    }
}
