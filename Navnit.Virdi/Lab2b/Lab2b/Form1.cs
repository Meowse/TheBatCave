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
            //  * What are eva.FirstName and eva.LastName?
            //  * The program will output Eva's first and last name for "eva"
            //  * What are ta.FirstName and ta.LastName?
            //  * The program will output Eva's first and last name for "ta"
            //  * What are mickey.FirstName and mickey.LastName?
            //  * The program will output Mickey's first and last name for "Mickey"
            //  * What are instructor.FirstName and instructor.LastName?
            //  * The program will output Mickey's first and last name for "instructor" as Michael Phoenix
            //  * The button called Fix Evas Name will change Eva's name to "Eva-Lise"

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            // The button called Fix Mickey's Name will change Michael to Mickey

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
            // The Ask for button Help will show the "ta" as the person to ask for help and their name.
            // The same button will show the "instructor" as the person to ask for help and their name. 
            // Not sure how the buttons will show the descriptions? ("the very helpful, also helpful?)
            // AFTER RUNNING PROGRAM: the button showed Eva has very helpful and Mickey as also helpful. I didn't realize a button could make two things happen. 


            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            // The button called "Give Mickey Martian Measles" will show a message saying Eva takes over as teacher for the class?
            // AFTER RUNNING PROGRAM: the output for instructor was assigned with the ta, which makes sense because Mickey gets the Martian Measels. 

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            // The button-MickeyShameNameChange will make mickey.firstname into "ex instructor" instead of Mickey, and his last name "ashes." 

            RedisplayNames();
        }

        private void RedisplayNames()
        {
            evaName.Text = eva.FirstName + " " + eva.LastName;
            taName.Text = ta.FirstName + " " + ta.LastName;
            mickeyName.Text = mickey.FirstName + " " + mickey.LastName;
            instructorName.Text = instructor.FirstName + " " + instructor.LastName;
        }
    }
}
