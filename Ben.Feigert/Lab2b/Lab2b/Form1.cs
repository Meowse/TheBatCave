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
                    //# eva.FirstName and eva.LastName are parameters of the object "eva". (is the object "overloaded"?),
                    //# value of eva.FirstName is "Eva-Lise", etc.
            //  * What are ta.FirstName and ta.LastName?
                    //# looks like they'd work the same way, only "ta" gets the values of whatever's in "eva"
            //  * What are mickey.FirstName and mickey.LastName?
                    //# same as ta.FirstName: parameters of the object mickey, which gets the values passed in "instructor"
            //  * What are instructor.FirstName and instructor.LastName?

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.

                  //# mickey.FirstName now has the value "Mickey" instead of "Michael", as a result of the button click
                  //# all other values are unchanged

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

                  //# value of eva.Firstname and eva.LastName are unchanged
                  //# ta.FirstName is "Eva-Lise" because personToAskForHelp gets values of ta
                  //# mickey.FirstName is "Mickey"; mickey.LastName is "Phoenix"
                  //# instructor.FirstName is "Mickey" because personToAskForHelp gets values of instructor in that line


            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
                  //# value of eva.FirstName is "Eva-Lise"; value of eva.LastName is "Carlstrom"
                  //# value of ta.FirstName is "Eva-Lise"; ta.LastName is "Carlstrom"
                  //# mickey.FirstName and mickey.LastName are unchanged
                  //# instructor.FirstName is "Eva-Lise"; instructor.LastName is "Carlstrom" because instructor gets the values of ta


            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
                  //# values of eva.FirstName and eva.LastName are unchanged
                  //# values of ta.FirstName and eva.LastName are unchanged
                  //# mickey.FirstName is "Ex-Instructor"; mickey.LastName is "Ashes"
                  //# instructor.FirstName and instructor.LastName are unchanged

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
