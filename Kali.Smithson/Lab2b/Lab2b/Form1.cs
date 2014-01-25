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
            //    Answer: Eva-Lise Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            //    Answer: Eva-Lise Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            //    Answer: Michael Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            //    Answer: Michael Phoenix

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            // Eva-Lise Carlstrom
            // Eva-Lise Carlstrom
            // Mickey Phoenix
            // Mickey Phoenix

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
            // The Very Helpful Eva-Lise Carlstrom
            // The Very Helpful Eva-Lise Carlstrom
            // The Also Helpful Mickey Phoenix
            // The Also Helpful Mickey Phoenix

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            // Eva-Lise Carlstrom
            //    Wrong answer - I didn't understand that the code above would overwrite the previous
            //                   codes - this part is missing from my below answers.
            // Eva-Lise Carlstrom
            // Mickey Phoenix
            // Eva-Lise Carlstrom

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            // Eva-Lise Carlstrom
            // Eva-Lise Carlstrom
            // Ex-Instructor Ashes
            // Eva-Lisa Carlstrom

            RedisplayNames();
        }

        private void RedisplayNames()
        {
            evaName.Text = eva.FirstName + " " + eva.LastName;
            taName.Text = ta.FirstName + " " + ta.LastName;
            mickeyName.Text = mickey.FirstName + " " + mickey.LastName;
            instructorName.Text = instructor.FirstName + " " + instructor.LastName;

            // EXTRA CREDIT: I predict that clicking the buttons out of order will default to the original 
            //               instrutions as it won't have a previous code to build on...?
            // ANSWER: It didn't exactly do what I thought, but it was still confused. So I think that the buttons
            //         can only change the 1 code that is being directly noticed.
        }
    }
}
