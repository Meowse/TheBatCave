using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
//Evolution of assignment 1
//First try: Tried scraping a website Http://Cellartracker.com for tasting notes on wine.
//Concept was a text box that allowed you to type a wine name in and select from a list of wines names that matched
//Clicking a button would have returned tasting notes for that wine
//Was making good progress finguring out the website URL's until the site decided I was a bot and threw up a captcha challenge

//Attempt 2
//Wanted to pull a random picture from the internet related to a users search term
//Downloaded a Flickr api and added the DLL to my project references
//Sample code had hard coded authentication strings that were not working for me
//Couldn't figure out how to authenticate

//Attempt 3
//Decided to translate a phone number to a list of all the possible alpha strings based on the letters of the keypad
//Researched Switch and dictionary functions and arrays... then realiazed that 0 and 1 have no corresponding alphas and switched tack to attempt 4

//Attempt 4
//Assignment is below
//Missed the initial commit checkin when saving the solution
//Struggled trying to figure out how to pipe a directory listing to the console from a windows form and eventually gave up on trying to create a scary
//Scrolling list of your C:/ drive



namespace First_Homework_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Boolean ExitNotOk = true; //


        private void button2_Click(object sender, EventArgs e) //
        { //
            ExitNotOk = false; //
            Form2 frm = new Form2(); //
            frm.Show();     //
        } //
        private void button1_Click(object sender, EventArgs e) //
        {
            ExitNotOk = false; //
            Form2 frm = new Form2(); //
            frm.Show(); //
        }
        private void button1_MouseEnter(object sender, EventArgs e) //
        {
            if (button1.Text == "No") //
            { //
                button1.Text = "Yes";  //
                button2.Text = "No"; //

            } //
        }

        private void button2_MouseEnter(object sender, EventArgs e) //
        {
            if (button2.Text == "No") //
            {
                button1.Text = "No"; //
                button2.Text = "Yes"; //

            } //
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //
        { //
            if (ExitNotOk) //
            { //
                MessageBox.Show("You must select a Yes or No button prior to exiting the program", "Exit Blocked", MessageBoxButtons.OK); //
                e.Cancel = true; //
            } //
        } //



    }
}
