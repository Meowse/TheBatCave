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
            //    eva.FirstName = Eva-Lise (after update)
            //    eva.Lastname = Carlstrom
            
            //  * What are ta.FirstName and ta.LastName?
            //    ta and eva are reference variables pointing to the same location in memory
            //    ta.FirstName = Eva-Lise (after update)
            //    ta.Lastname = Carlstrom

            //  * What are mickey.FirstName and mickey.LastName?
            //    instructor and mickey are reference variables pointing to the same location in memory
            //    mickey.FirstName = Michael 
            //    mickey.LastName = Phoenix

            //  * What are instructor.FirstName and instructor.LastName?
            //    instructor.FirstName = Michael 
            //    instructor.LastName = Phoenix

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            // No changes to eva or ta in this method
            //    mickey.FirstName = Mickey 
            //    mickey.LastName = Phoenix
            //    instructor.FirstName = Mickey 
            //    instructor.LastName = Phoenix


            RedisplayNames();
        }

        private void askForHelpButton_Click(object sender, EventArgs e)
        {
            // 3) Ask first the TA, and then the instructor, for help
            Person personToAskForHelp = ta;
            personToAskForHelp.FirstName = "The Very Helpful " + personToAskForHelp.FirstName;
            personToAskForHelp = instructor;
            personToAskForHelp.FirstName = "The Also Helpful " + personToAskForHelp.FirstName;

            // Working on the premise that the buttons are pushed in order from top to bottom
            // Same questions...
            //    eva.FirstName = The Very Helpful Eva-Lise 
            //    eva.Lastname = Carlstrom
            //    ta.FirstName = The Very Helpful Eva-Lise 
            //    ta.Lastname = Carlstrom

            //    mickey.FirstName = The Also Helpful Mickey 
            //    mickey.LastName = Phoenix
            //    instructor.FirstName = The Also Helpful Mickey 
            //    instructor.LastName = Phoenix

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            //    eva.FirstName = The Very Helpful Eva-Lise 
            //    eva.Lastname = Carlstrom
            //    ta.FirstName = The Very Helpful Eva-Lise 
            //    ta.Lastname = Carlstrom

            //    Oops!
            //    mickey.FirstName = The Very Helpful Eva-Lise 
            //    mickey.LastName = Carlstrom

            //    instructor.FirstName = The Very Helpful Eva-Lise
            //    instructor.LastName = Carlstrom

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            //    Oops!
            //    eva.FirstName = Ex-Instructor
            //    eva.Lastname = Ashes
            //    ta.FirstName = Ex-Instructor
            //    ta.Lastname = Ashes

            //    Oops!
            //    mickey.FirstName = Ex-Instructor
            //    mickey.LastName = Ashes
            //    instructor.FirstName = Ex-Instructor
            //    instructor.LastName = Ashes

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
