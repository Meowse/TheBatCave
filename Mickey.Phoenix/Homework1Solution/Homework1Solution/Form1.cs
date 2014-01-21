using System;
using System.Windows.Forms;
using Homework1Solution.Properties;

namespace Homework1Solution
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doSomething_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.ClickToPutUpMessageBox);
        }

        private void learnBetterLink_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.LearningByDoing);
        }
    }
}
