using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WritingDesk
{
    public partial class Form1 : Form
    {
        private Pen _pen;

        public Form1()
        {
            InitializeComponent();
        }

        private void getNewPageButton_Click(object sender, EventArgs e)
        {
            currentPage.Text = "";
        }

        private void buyFeltTipPenButton_Click(object sender, EventArgs e)
        {
            _pen = new FeltTipPen();
        }

        private void buyCheapBallPointPenButton_Click(object sender, EventArgs e)
        {
            _pen = new BallPointPen(1);
        }

        private void buyExpensiveBallPointPenButton_Click(object sender, EventArgs e)
        {
            _pen = new BallPointPen(20);
        }

        private void writeSomethingButton_Click(object sender, EventArgs e)
        {
            // TODO: implement this method so that it uses MessageBox.Show()
            // to report error conditions (no pen, pen is out of ink, pen
            // is dry, etc.), and otherwise writes a message to the current 
            // page.
        }
    }
}
