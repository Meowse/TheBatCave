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
            // Felt tipped pens last 30 minutes
            _pen = new FeltTipPen();
        }

        private void buyCheapBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $1 ball-point pen.
            // Ball point pens last 1 hour per $1 spent
            _pen = new BallPointPen(1);
        }

        private void buyExpensiveBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $20 ball-point pen.
            // Ball point pens last 1 hour per $1 spent
            _pen = new BallPointPen(20);
        }

        private void writeSomethingButton_Click(object sender, EventArgs e)
        {
            // implement this method so that it uses MessageBox.Show()
            // to report error conditions (no pen, pen is out of ink, pen
            // is dry, etc.), and otherwise writes a message to the current 
            // page.
            if (_pen == null)
            {
                MessageBox.Show(@"You need a pen in order to write anything");
            }
            else if (_pen.PenIsDry)
            {
                MessageBox.Show(@"The pen has dried out!");
            }
            else if(_pen.Capped)
            {
                MessageBox.Show(@"The pen must be uncapped in order to write");
            }
            else
            {
                _pen.Write("something");
                currentPage.Text += "Wrote something with our pen.\r\n";
            }
            
            // For extra credit, feel free to have the "Write" method 
            // age a pen by 1 minute, to represent the time/ink spent writing.
            
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {
            // Add stuff to this method so that it uses MessageBox.Show()
            // to report error conditions (such as "can't cap a pen that is already
            // capped").
            if (_pen.Capped)
            {
                MessageBox.Show(@"The pen is already capped");
            }
            else
            {
                MessageBox.Show(@"The pen is capped");
                _pen.Capped = true;
            }
        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {
            // Add stuff to this method so that it uses MessageBox.Show()
            // to report error conditions (such as "can't uncap a pen that is already
            // uncapped").
            if (_pen.Capped)
            {
                MessageBox.Show(@"The pen has been uncapped");
                _pen.Capped = false;
            }
            else
            {
                MessageBox.Show(@"The pen is already uncapped");
            }
        }

        private void waitFiveMinutesButton_Click(object sender, EventArgs e)
        {
            // Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            if (!_pen.Capped)
            {
                _pen.MinutesPass(5);
            }
            
        }

        private void waitOneHourButton_Click(object sender, EventArgs e)
        {
            // Implement the MinutesPass method so that your pen
            // "ages" by 60 minutes.
            if (!_pen.Capped)
            {
                _pen.MinutesPass(60);
            }
            
        }
    }
}
 