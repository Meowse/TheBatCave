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
        }

        private void fixEvaNameButton_Click(object sender, EventArgs e)
        {
            // 1) Fix Eva's name
            eva.FirstName = "Eva-Lise";

            // Questions:
            //  * What are eva.FirstName and eva.LastName? They will be "Eva-Lise" and "Carlstrom"-Paul C.
            //  * What are ta.FirstName and ta.LastName? These will be the same as above because "ta" now equals "eva"-Paul C.
            //  * What are mickey.FirstName and mickey.LastName? They will be "Michael" and "Phoenix"-Paul C.
            //  * What are instructor.FirstName and instructor.LastName? These will be the same as above because "mickey" now equals "instructor"-Paul C.

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before. Now mickey.FirstName will be changed from "Michael" to "Mickey"-Paul C.

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
            // Window will present the user to ask for help. Available selections will be "ta" or "instructor"-Paul C.
            // If the user clicks on "ta" button then the window will display the following message: "The Very Helpful Eva-Lise Carlstrom"-Paul C.
            // If the user click on "isntructor" button then the window will display the following message: "The Also Helpdul Mickey Phoenix"-Paul C.

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            //Window will present user with a button "giveMickeyMartianMeasles"-Paul C.
            //If the user clicks the button then instructor will be changed from "Mickey Phoenix" to "Eva-Lise Carlstrom" -Paul C.
            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            //Window will present user with a button "mickeyShameNameChangeButton" -Paul C.
            //If the user clicks the button then the instructor will be changed from "Mickey Phoenix" to "Ex-Instructor Ashes"-Paul C.

            RedisplayNames();
        }

        private void RedisplayNames()
        {
            evaName.Text = eva.FirstName + " " + eva.LastName;
            taName.Text = ta.FirstName + " " + ta.LastName;
            mickeyName.Text = mickey.FirstName + " " + mickey.LastName;
            instructorName.Text = instructor.FirstName + " " + instructor.LastName;

            //Conclusion: I was mostly correct in my individual predictions, but I failed to account for the actions in all of the other variables. I had a narrow focus 
            // and should have kept a "big picture" mindset. Paul C.
        }
    }
}
