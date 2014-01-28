using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2b
{
    public partial class Form1 : Form
    {
        private Person instructor;
        private Person mickey;
        private Person ta;
        private Person eva;

        public Form1()
        {
            InitializeComponent();

            instructor = new Person { FirstName = "Michael", LastName = "Phoenix" };
            mickey = instructor;
            eva = new Person { FirstName = "Eva", LastName = "Carlstrom" };
            ta = eva;

            // Update the UI (the User Interface) with the current names.
            RedisplayNames();
            evaName.Text = "Eva-Lise Carlstrom";
        }

        private void fixEvaNameButton_Click(object sender, EventArgs e)
        {
            // 1) Fix Eva's name
            

            // Questions:
            //  * What are eva.FirstName and eva.LastName? 
            //    Eva-Lise, Carlstrom
            //      (once I ran it) Eva, Carlstrom. It wasn't Eva-Lise because that was the inital label text, not the text that was run in the .FirstName .LastName
            //  * What are ta.FirstName and ta.LastName?
            //    Eva-Lise, Carlstrom
            //      Eva Carlstrom Same as above; it didn't run the label text, it ran the instructed .FirstName .LastName text
            //  * What are mickey.FirstName and mickey.LastName?
            //      Michael, Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            //      Michael, Phoenix

            RedisplayNames();
                           
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            // Eva, Carlstrom
            // Eva, Carlstrom
            // Mickey, Phoenix
            // Mickey, Phoenix

            RedisplayNames();
        }

        private void askForHelpButton_Click(object sender, EventArgs e)
        {
            // 3) Ask first the TA, and then the instructor, for help
            Person personToAskForHelp = ta;
            personToAskForHelp.FirstName = "The Very Helpful " + personToAskForHelp.FirstName;
            personToAskForHelp = instructor;
            personToAskForHelp.FirstName = "The Also Helpful " + personToAskForHelp.FirstName;

            // Same questions...
            // The Very Helpful, Eva Carlstrom
            // The Very Helpful, Eva Carlstrom
            // The Also Helpful, Michael Phoenix
            // The Also Helpful, Michael Phoenix

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            // Eva, Carlstrom
            // Eva, Carlstrom
            // Michael, Phoenix
            // Eva, Carlstrom

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            // Eva, Carlstrom
            // Eva, Carlstrom
            // Ex-Instructor, Ashes
            // Ex-Instructor, Ashes


            //Extra credit predictions: when you click the buttons out of order, it will keep the original reference. For example, if you begin with
            //'shame-change' and change Mickey/Instructor name to Ex-Instructor Ashes, when you click "Ask TA for help then Instructor,' everything 
            //will still turn into "A very helpful person," and all of those will change to Eva Carlstrom and Michael Phoenix when you click
            //'Fix Eva's Name'

            //Result: While it everything changed to "a very helpful person," it stayed that way even when "Fix Eva's Name" and "Fix Mickey's
            //Name" was clicked.

            //New Prediction: I think this is because "a very helpful person" redefined the value for TA and Instructor, whereas "shame-change"
            //only changed the mickey.First/Lastname values. I predict if you "shame-change" first and then "fix eva/mickey names", ex-instructor
            //ashes will change back to Michael Phoenix (for fix Eva, Mickey for Fix Mickey). If you start with "a very helpful", it will stay
            //as A very helpful unless you click "martian measles" and vice versa.

            //Result: Since Eva's name was "eva carlstrom" in both "shame-change" and "fix eva/mickey", I was unable to see a change in eva's name.
            //However, when I clicked "Fix eva", Mickey's name stayed as Ex-Instructor and didn't change until I clicked "Fix Mickey", when it
            //fixed Mickey's name. I think this is because the command "Fix Eva" doesn't contain a change in Mickey's name, so the latest value
            //for Mickey's name (Ex-Instructor) remained the same. However, "Fix Mickey" DOES contain a change, so that took presidence. 

            //New Prediction: When you click the buttons out of order, it will keep the most recently used reference unless there is a specific command
            //used to change it. So if you begin with "a very helpful..." and then go "Martian Measles", the instructor becomes "The Very helpful
            //Eva Carlstrom," because the first button redefined TA as "very helpful eva" and Instructor as "also helpful mickey", and martian measles
            //replaces instructor with ta. 

            RedisplayNames();
        }

        private void RedisplayNames()
        {
            evaName.Text = eva.FirstName + " " + eva.LastName;
            taName.Text = ta.FirstName + " " + ta.LastName;
            mickeyName.Text = mickey.FirstName + " " + mickey.LastName;
            instructorName.Text = instructor.FirstName + " " + instructor.LastName;
        }

        private void evaName_Click(object sender, EventArgs e)
        {

        }
    }
}
