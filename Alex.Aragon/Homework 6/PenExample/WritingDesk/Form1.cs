using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using PenExample;

namespace WritingDesk
{
    public partial class Form1 : Form
    {
        private Pen _pen;
        private int _bookLine;

        public Form1()
        {
            InitializeComponent();
        }

        private void getNewPageButton_Click(object sender, EventArgs e)
        {
            currentPage.Text = "";
            _bookLine = 0;
        }

        private void buyFeltTipPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a felt-tipped pen.
            _pen = new FeltTipPen();
            currentPenLabel.Text = "You have a Felt Tip Pen";
        }

        private void buyCheapBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $1 ball-point pen.
            _pen = new BallPointPen(1);
            currentPenLabel.Text = "You have a Cheap Ball Point Pen";
        }

        private void buyExpensiveBallPointPenButton_Click(object sender, EventArgs e)
        {
            // Throws away your old pen and replaces it with a $20 ball-point pen.
            _pen = new BallPointPen(20);
            currentPenLabel.Text = "You have an Expensive Ball Point Pen";
        }
        private void writeSomethingButton_Click(object sender, EventArgs e)
        {
            // TODO: implement this method so that it uses MessageBox.Show()
            // to report error conditions (no pen, pen is out of ink, pen
            // is dry, etc.), and otherwise writes a message to the current 
            // page.
            if (_pen == null)
            {
                MessageBox.Show("You need to buy a pen first.");
            }
            else if (_pen.Capped)
            {
                MessageBox.Show("You need to uncap your pen before you write.");
            }
            else
            {
                if (_pen.DryingTimeInMinutes < 0)
                {
                    MessageBox.Show("Your pen is out of ink");
                }
                else
                {
                    List<string> book = getBook();
                    if (_bookLine == 0)
                        currentPage.Text = book[_bookLine];
                    else
                        currentPage.Text += book[_bookLine];
                    _bookLine++;
                    _pen.MinutesPass(1);
                }
            }

            // For extra credit, feel free to have the "Write" method 
            // age a pen by 1 minute, to represent the time/ink spent writing.
            //_pen.Write("something");
            // currentPage.Text += "\nWrote something with our pen.";
        }

        private void capPenButton_Click(object sender, EventArgs e)
        {
            // TODO: Add stuff to this method so that it uses MessageBox.Show()
            // to report error conditions (such as "can't cap a pen that is already
            // capped").
            if (_pen == null)
            {
                MessageBox.Show("You need to buy a pen first.");
            }
            else if (_pen.Capped)
                MessageBox.Show("You can't cap a pen that is already capped.");
            else
            {
                _pen.Capped = true;
            }
        }

        private void uncapPenButton_Click(object sender, EventArgs e)
        {
            // TODO: Add stuff to this method so that it uses MessageBox.Show()
            // to report error conditions (such as "can't uncap a pen that is already
            // uncapped").
            if (_pen == null)
            {
                MessageBox.Show("You need to buy a pen first.");
            }
            else if (!_pen.Capped)
                MessageBox.Show("You can't uncap a pen that is already uncapped");
            else {
                _pen.Capped = false;
            }
        }

        private void waitFiveMinutesButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            if (_pen == null)
            {
                MessageBox.Show("Try buying a pen first.");
            }
            else
            _pen.MinutesPass(5);
        }

        private void waitOneHourButton_Click(object sender, EventArgs e)
        {
            // TODO: Implement the MinutesPass method so that your pen
            // "ages" by 5 minutes.
            if (_pen == null)
            {
                MessageBox.Show("Try buying a pen first.");
            }
            else
            _pen.MinutesPass(60);
        }

        public List<string> getBook()
        {
            try
            {
                using (
                    StreamReader sr =
                        new StreamReader(
                            @"D:\Aragon\My Documents\GitHub\TheBatCave\Alex.Aragon\Homework 6\PenExample\taleoftwocities.txt")
                    )
                {

                    List<string> list = new List<string>();
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        list.Add(line); // Add to list.
                    }

                    return list;
                }
            }
            catch (Exception e)
            {

                List<string> error = new List<string>();
                error.Add("The file could not be read");
                //Console.WriteLine(e.Message);
                return error;
            }
        }
    }

    internal class FeltTipPen : Pen
    {
    }

    internal class BallPointPen : Pen
    {
        public BallPointPen(int penType)
        {
            if(penType == 1)
                DryingTimeInMinutes = 45;
            else
                DryingTimeInMinutes = 60;
            Capped = true;
        }
    }
}
