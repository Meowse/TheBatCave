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
            //  A: eva.FirstName has been specified as Eva-Lise. Eva.LastName doesn't appear to be specified. Up above, the listing of
            //     Eva = new person ...  doesn't appear, to me, to directly relate to eva.FirstName and eva.LastName.
            //  * What are ta.FirstName and ta.LastName?
            //  A: By logic of eva=ta, I think ta.FirstName = Eva and ta.LastName = Carlstrom. But, if there is no clear definition of ta.FirstName
            //     or ta.LastName, I'm not sure if it would work, if ran.
            //  * What are mickey.FirstName and mickey.LastName?
            //  A: From what I can see here, I don't think they've been defined. 
            //  * What are instructor.FirstName and instructor.LastName?
            //  A: Instructor first name is Michael and last name is Phoenix. 
            //
            //  In actuality, when this button was clicked, Eva Carlstrom was changed to Eva-Lise Carlstrom in both the Eva and TA fields.


            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            // A: I think that this would convert Instructor=Mickey's firstname from Michael to Mickey. 
            //
            // In actuality, clicking the button changed Michael to Mickey in both the Instructor and Mickey fields. 

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
            // For TA, Eva Carlstrom would be displayed. For Instructor, Michael Phoenix would be displayed. Both would 
            // be appended with the Helpful terminology.
            //
            // In actuality, names were not corrected but both were pre-pended with their "Very Helpful" titles.

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            // With this button, when run, the code will replace instructor with TA.
            //
            // When run, the instructor field is the only item to change: from Michael Phoenix to Eva Carlstrom.


            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            // Okay, so by here, I'm definitely not sure. It might never be used because mickey.FirstName 
            // mickey.LastName are never defined this way anywhere here so it would blow up. Or, it would replace 
            // every reference to Mickey Phoenix with Ex-Instructor Ashes. Or, it could be some combination of the two. 
            //
            //  When run, this one changes both Instructor and Mickey to Ex-Instructor Ashes. 

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
