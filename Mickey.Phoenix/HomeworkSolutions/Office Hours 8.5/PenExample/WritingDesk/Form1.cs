using System;
using System.Windows.Forms;
using PenExample;

namespace WritingDesk
{
    // DONE: Fix the bug that happens when you try to cap or uncap and don't
    // yet have a pen.
    public partial class Form1 : Form
    {
        // Can be references (gotten or set) anywhere in my program by using the 
        // name "WritingDesk.Form1.VisibleEverywhereInMyProgram".
        // This is a bad thing to do, because it means that in order to analyze the
        // behavior of the program, you have to analyze the *entire* program and look
        // at *everywhere* this variable is accessed or set.
        public static String VisibleEverywhereInMyProgram = "Effectively global";

        private const string PenPurchasePrompt = "Please buy a pen.";
        private const string PenMissingMessage = "You do not have a pen.";
        private const string BadDayMessage = "Some days are like that.  Better luck tomorrow!";

        // There is no class invariant that says we will always have
        // a value in _pen, so all of our logic in our class needs to 
        // take the "_pen == null" case into account.
        //
        // If we invented a "NoPen" pen, which responded with the
        // error message "Please buy a pen." to anything you did to it,
        // we could add the class invariant "_pen will always have a value",
        // and our code would get a lot simpler.
        private Pen _pen;

        public Form1()
        {
            InitializeComponent();
        }

        private void getNewPageButton_Click(object sender, EventArgs e)
        {
            currentPage.Text = "";
        }

        // Throws away your old pen and replaces it with a felt-tipped pen.
        private void buyFeltTipPenButton_Click(object sender, EventArgs e)
        {
            // 1) Declares a local variable named "pen" that holds references to
            // Pen objects.
            // 2) Creates a new FeltTipPen instance (object) using the "new" keyword
            // and the FeltTipPen constructor method.
            // 3) Puts a reference to the new FeltTipPen instance/object into the
            // local variable "pen"
            Pen pen = new FeltTipPen();

            // 1) Asks the local variable "pen" for the value of its "Description" 
            // property.
            // 2) Writes out that value to the console.
            Console.WriteLine(pen.Description);

            // Copies the reference (to the new FeltTipPen instance) from the 
            // local variable "pen" to the instance variable "_pen".
            // This has two effects:
            // 1) The value will be available after this method is done executing,
            // because instance variables live as long as the instance lives, and
            // 2) It will be visible in other methods, like "UpdateUi()", because
            // instance variables are visible to all methods of the class.
            _pen = pen;
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
            // Guard condition -- if something is wrong, exit the method
            // at the beginning with a return.  Good if the method is long
            // and/or complicated, and the guard condition is simple.
            if (_pen == null)
            {
                MessageBox.Show(PenPurchasePrompt);
                return;
            }

            // Extra credit: add a text field to the form that allows the
            // user to enter text for the pen to "write", and use it here.
            string written = _pen.Write("This was written by the pen!");

            if (written != null)
            {
                // DONE: Fix the bug in this line of code.  Of course, you'll
                // have to find it, first.  :-)
                currentPage.Text += written + Environment.NewLine;
            }
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {
            // Instead of a guard condition, we've build the check for
            // "no pen" into the logic of the method.  Good if the
            // method is short and simple.
            if (_pen != null)
            {
                _pen.IsCapped = true;
            }
            else
            {
                MessageBox.Show(PenPurchasePrompt);
            }
            UpdateUi();
        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {
            if (_pen == null)
            {
                MessageBox.Show(PenPurchasePrompt);
                return;
            }
            _pen.IsCapped = false;
            UpdateUi();
        }

        private void waitFiveMinutesButton_Click(object sender, EventArgs e)
        {
            if (_pen == null)
            {
                MessageBox.Show(PenPurchasePrompt);
                return;
            }
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            _pen.MinutesPass(5);
        }

        private void waitOneHourButton_Click(object sender, EventArgs e)
        {
            if (_pen == null)
            {
                MessageBox.Show(PenPurchasePrompt);
                return;
            }
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by an hour.
            _pen.MinutesPass(60);
        }

        private void giveUpForTheDayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(BadDayMessage);
            if (_pen != null)
            {
                _pen.MinutesPass(60 * 12);
            }
        }

        private void throwAwayPenButton_Click(object sender, EventArgs e)
        {
            if (_pen == null)
            {
                MessageBox.Show(PenMissingMessage);
                return;
            }
            _pen = null;
            UpdateUi();
        }

        // DONE: Implement everything needed to make the UI properly
        // consistent with the state of the pen.
        //
        // DONE: Add calls to UpdateUi() wherever you feel they are needed.
        // NOTE: This may depend on which parts of the UI are updated in
        // UpdateUi(), since you only want to call UpdateUi() after changes
        // that will show up in the UI.
        private void UpdateUi()
        {
            // TODO: Fix the bug on this line.
//            if (_pen == null)
//            {
//                currentPenLabel.Text = "You do not own a pen.";
//            }
//            else
//            {
//                currentPenLabel.Text = _pen.Description;
//            }
            currentPenLabel.Text = (_pen == null)
                ? "You do not own a pen."
                : _pen.Description;

            if (_pen != null)
            {
                capPenButton.Enabled = !_pen.IsCapped;
                uncapPenButton.Enabled = _pen.IsCapped;
            }
            else
            {
                capPenButton.Enabled = true;
                uncapPenButton.Enabled = true;
            }
        }
    }
}
