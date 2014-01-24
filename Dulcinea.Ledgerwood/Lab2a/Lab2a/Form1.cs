using System;
using System.Globalization;
using System.Windows.Forms;

namespace Lab2a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] words =
            {
                "Hello world", "one two three", "\"\"\"", @"\\\\", "\"\\\"\"", "\"\"\\\"\"\"\\\\\\\"\\\"\""
            };

            int nine = 9;
            int five = 5;
            int outnum = nine*five;

            output1.Text = words[0];
            output2.Text = string.Format("{0}",words[1]);
            output3.Text = outnum.ToString(CultureInfo.InvariantCulture);
            output4.Text = words[2];
            output5.Text = words[3];
            output6.Text = words[4];
            output7.Text = words[5];

        }
    }
}
