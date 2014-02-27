using System;
using System.Windows.Forms;
using PenExample;

namespace WritingDesk
{
    // TODO: Fix the bug that happens when you try to cap or uncap and don't
    // yet have a pen.
    public partial class Form1 : Form
    {
        private Pen _pen;
        Timer _penTimer = new Timer();

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
            UpdateUi();
        }

        private void buyCheapBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $1 ball-point pen.
            _pen = new BallPointPen(1);
            UpdateUi();
        }

        private void buyExpensiveBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $20 ball-point pen.
            _pen = new BallPointPen(20);
            UpdateUi();
        }

        private void writeSomethingButton_Click(object sender, EventArgs e)
        {
            // Extra credit: add a text field to the form that allows the
            // user to enter text for the pen to "write", and use it here.

            if (_pen == null)
            {
                MessageBox.Show("You need a pen to write with");
                return;
            }
            if (_pen.Capped)
            {
                MessageBox.Show("You need to uncap the pen to  write something!");
                return;
            }
            // TODO: Fix the bug in this line of code.  Of course, you'll
            // have to find it, first.  :-)
            string written = _pen.Write("This was written by the pen!");
            currentPage.Text += Environment.NewLine + written;
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {
            if (_pen == null)
            {
                MessageBox.Show("You need a pen first");
                return;
            }
            if (_pen.Capped)
            {
                MessageBox.Show("You need to uncap your pen");
                return;
            }
            _pen.Capped = true;
            _penTimer.Start();
        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {
            if (_pen == null)
            {
                MessageBox.Show("You need a pen first");
                return;
            }
            if (_pen.Capped == false)
            {
                MessageBox.Show("You need to cap your pen");
                return;
            }
            _pen.Capped = false;
            _penTimer.Start();
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
            // "ages" by an hour.
            _pen.MinutesPass(60);
        }

        private void throwAwayPenButton_Click(object sender, EventArgs e)
        {
            _pen = null;
            StopPenTimer();
            UpdateUi();
        }

        // TODO: Implement everything needed to make the UI properly
        // consistent with the state of the pen.
        //
        // TODO: Add calls to UpdateUi() wherever you feel they are needed.
        // NOTE: This may depend on which parts of the UI are updated in
        // UpdateUi(), since you only want to call UpdateUi() after changes
        // that will show up in the UI.
        private void UpdateUi()
        {
            // TODO: Fix the bug on this line.

            if (_pen == null)
            {
                currentPenLabel.Text = "You do not own a pen.";
            }
            else
            {
                currentPenLabel.Text = _pen.Description;
                _pen.Capped = true;
                _penTimer.Enabled = true;
                _penTimer.Start();
            }
        }

        private void StopPenTimer()
        {
            _penTimer.Enabled = false;
            _penTimer.Stop();
        }
    }
}
