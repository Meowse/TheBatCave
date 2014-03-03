using System;
using System.Diagnostics.Eventing.Reader;
using System.Security.Policy;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using PenExample;

namespace WritingDesk
{
    // TODO: Fix the bug that happens when you try to cap or uncap and don't
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
            if (_pen != null && _pen.Capped != true)
            {
                var written = _pen.Write("something");
                
                currentPage.Text += Environment.NewLine + written;
                UpdateUi();
            }
            else 
            {
                if (_pen == null)
                {
                    PenOwnershipCheck();
                }
                else MessageBox.Show("You must uncap your pen in order to write.");
            }


            // TODO: Fix the bug in this line of code.  Of course, you'll
            // have to find it, first.  :-)
            
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {


            if (_pen != null)
            {
                if (_pen.Capped == false)
                {
                    _pen.Capped = true;
                    UpdateUi();
                }
                else MessageBox.Show("You cannot cap a capped pen.");
            }
            else PenOwnershipCheck();


        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {


            if (_pen != null)
            {
                if (_pen.Capped == true)
                {
                    _pen.Capped = false;
                    UpdateUi();
                }
                else MessageBox.Show("You cannot un-cap a pen that is not capped.");
            }
            else PenOwnershipCheck();

        }

        private void waitFiveMinutesButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            if (_pen != null)
            {
                _pen.MinutesPass(5);
                UpdateUi();
            }
            else PenOwnershipCheck();
        }

        private void waitOneHourButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by an hour.
            if (_pen != null)
            {
                _pen.MinutesPass(60);
                UpdateUi();
            }
            else PenOwnershipCheck();
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
            string capState;
            string timeLeft;
            if (_pen != null)
            {
                {
                    if (_pen.Capped == true )
                    {
                        capState = "Capped";
                    }
                    else
                    {
                        capState = "Un-capped";
                    }
                }

                {
                    if (_pen.DryingTimeInMinutes > 0)
                    {
                        timeLeft = _pen.DryingTimeInMinutes.ToString();
                    }
                    else
                    {
                        timeLeft = "0";
                    }
                }

                currentPenLabel.Text = _pen.Description + " (" + capState + ", with " + timeLeft + " minutes remaining)";
            }
            else currentPenLabel.Text = "You do not currently own a pen.";
        }

        private void currentPage_TextChanged(object sender, EventArgs e)
        {

        }


        private void PenOwnershipCheck()
        {
            if (_pen == null)
            {
                MessageBox.Show("You must own a pen to perform this function.");
            }
        }
    }
}
