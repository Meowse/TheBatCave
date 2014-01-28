using System;
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
            //Assumuption: fixEvaNameButton was the only button pressed.
            //Results could vary depending on sequence of buttons pressed.
            //  * What are eva.FirstName and eva.LastName? 
                    // eva.First is Eva-Lise and eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName?
                    // ta.FirstName is Eva and ta.LastName is Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
                    // mickey.FirstName is Michael and mickey.LastName is Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
                    // instructor.FirstName is Michael and instructor.LastName is Phoenix

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            //Assumuption: fixMickeyNameButton was the only button pressed.
            //Results could vary depending on sequence of buttons pressed.
            //  * What are eva.FirstName and eva.LastName? 
            // eva.First is Eva and eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName is Eva and ta.LastName is Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName is Mickey and mickey.LastName is Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName is Michael and instructor.LastName is Phoenix

            RedisplayNames();
        }

        private void askForHelpButton_Click(object sender, EventArgs e)
        {
            // 3) Ask first the TA, and then the instructor, for help
            Person personToAskForHelp = ta;
            personToAskForHelp.FirstName = "The Very Helpful " + personToAskForHelp.FirstName;
            personToAskForHelp = instructor;
            personToAskForHelp.FirstName = "The Also Helpful " + personToAskForHelp.FirstName;

            // Questions:
            //Assumuption: askForHelpButton was the only button pressed.
            //Results could vary depending on sequence of buttons pressed.
            //  * What are eva.FirstName and eva.LastName? 
            // eva.First is Eva and eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName is Eva and ta.LastName is Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName is Michael and mickey.LastName is Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName is Michael and instructor.LastName is Phoenix


            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Questions:
            //Assumuption: giveMickeyMartianMeaslesButton was the only button pressed.
            //Results could vary depending on sequence of buttons pressed.
            //  * What are eva.FirstName and eva.LastName? 
            // eva.First is Eva and eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName is Eva and ta.LastName is Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName is Michael and mickey.LastName is Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName is Eva and instructor.LastName is Carlstrom


            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Questions:
            //Assumuption: mickeyShameNameChangeButton was the only button pressed.
            //Results could vary depending on sequence of buttons pressed.
            //  * What are eva.FirstName and eva.LastName? 
            // eva.First is Eva and eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName is Eva and ta.LastName is Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName is Ex-Instructor and mickey.LastName is Ashes
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName is Michael and instructor.LastName is Pheonix


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
