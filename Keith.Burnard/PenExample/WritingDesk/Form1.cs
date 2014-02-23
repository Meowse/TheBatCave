using System;
using System.Windows.Forms;
using PenExample;

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
            // Throws away your old pen and replaces it with a felt-tipped pen.
            _pen = new FeltTipPen();
        }

        private void buyCheapBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $1 ball-point pen.
            _pen = new BallPointPen(1);
        }

        private void buyExpensiveBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $20 ball-point pen.
            _pen = new BallPointPen(20);
        }

        private void writeSomethingButton_Click(object sender, EventArgs e)
        {
            // TODO: implement this method so that it uses MessageBox.Show()
            // to report error conditions (no pen, pen is out of ink, pen
            // is dry, etc.), and otherwise writes a message to the current 
            // page.
            
            // For extra credit, feel free to have the "Write" method 
            // age a pen by 1 minute, to represent the time/ink spent writing.
            _pen.Write("something");
            currentPage.Text += "\nWrote something with our pen.";
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {
            // TODO: Add stuff to this method so that it uses MessageBox.Show()
            // to report error conditions (such as "can't cap a pen that is already
            // capped").
            _pen.Capped = true;
        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {
            // TODO: Add stuff to this method so that it uses MessageBox.Show()
            // to report error conditions (such as "can't uncap a pen that is already
            // uncapped").
            _pen.Capped = false;
        }

        private void waitFiveMinutesButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            _pen.MinutesPass(5);
        }

        private void waitOneHourButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            _pen.MinutesPass(60);
        }
    }
}
