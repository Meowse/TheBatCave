using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SomethingInteresting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AnswerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A bañaña...\n\t...it's only funny if you know spanish.  :)");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stillaboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();
            box.ShowDialog();
        }
    }
}
