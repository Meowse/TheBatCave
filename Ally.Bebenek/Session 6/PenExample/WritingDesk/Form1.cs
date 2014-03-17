using System;
using System.Windows.Forms;
using PenExample;

namespace WritingDesk
{
    // DONE: Fix the bug that happens when you try to cap or uncap and don't
    // yet have a pen.
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
            if (ValidatePen())
            {
                string written = _pen.Write("This was written by the pen!");

                // DONE: Fix the bug in this line of code.  Of course, you'll
                // have to find it, first.  :-)
                currentPage.Text += Environment.NewLine + written;
            }
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {
            if (ValidatePen())
                _pen.Capped = true;
        }

        private bool ValidatePen()
        {
            if (_pen == null)
            {
                MessageBox.Show("You dont have a pen yet");
                return false;
            }
            return true;
        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {
            if (ValidatePen())
                _pen.Capped = false;
        }

        private void waitFiveMinutesButton_Click(object sender, EventArgs e)
        {
            // DONE: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            if(ValidatePen())
            _pen.MinutesPass(5);
        }

        private void waitOneHourButton_Click(object sender, EventArgs e)
        {
            // DONE: Implement the MinutesPass method so that your pen
            // "ages" by an hour.
            if(ValidatePen())
            _pen.MinutesPass(60);
        }

        private void throwAwayPenButton_Click(object sender, EventArgs e)
        {
            _pen = null;
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
            if (ValidatePen())
            {
                currentPenLabel.Text = _pen.Description;
            }
            else currentPenLabel.Text = string.Empty;
        }
    }
}
