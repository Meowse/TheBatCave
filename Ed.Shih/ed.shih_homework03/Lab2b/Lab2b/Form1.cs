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
            //	They are properties of the Person called eva with values of "Eva-Lise" and "Carlstrom".
            //  * What are ta.FirstName and ta.LastName?
            //	They are properties of ta which is also equal to eva with values of "Eva-Lise" and "Carlstrom".
            //  * What are mickey.FirstName and mickey.LastName?
            //	They are properties of the Person called mickey with values of "Michael" and "Phoenix".
            //  * What are instructor.FirstName and instructor.LastName?
            //	They are properties of instructor which is also equal to mickey with values of "Michael" and "Phoenix".

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            //	eva.FirstName and eva.LastName are unchanged.
            //	ta.FirstName and ta.LastName are unchanged.
            //	mickey.FirstName is now "Mickey" and mickey.LastName is unchanged.
            //	instructor.FirstName and instructor.LastName are unchanged because the change was only applied to mickey. mickey = instructor does not mean instructor = mickey.

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
            //	eva.FirstName and eva.LastName are unchanged because personToAskForHelp = ta not eva = personToAskForHelp.
            //	ta.FirstName and ta.LastName are unchanged because personToAskForHelp = ta not ta = personToAskForHelp.
            //	mickey.FirstName and mickey.LastName are unchanged because personToAskForHelp = instructor not instructor = personToAskForHelp.
            //	instructor.FirstName and instructor.LastName are unchanged because personToAskForHelp = instructor not instructor = personToAskForHelp.

            //  Ran the solution and I'm surprised that the values changed. I thought the = did not mean equals so I did not think the properties would transfer like that.

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            //	eva.FirstName and eva.LastName are unchanged.
            //	ta.FirstName and ta.LastName are unchanged.
            //	mickey.FirstName and mickey.LastName are unchanged.
            //	instructor.FirstName is "Eva-Lise" and instructor.LastName is "Carlstrom" because instrutor = ta and ta = eva.

            //  Ran the solution and I'm surprised that the values changed. I thought the = did not mean equals so I did not think the properties would transfer like that.

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            //	eva.FirstName and eva.LastName are unchanged.
            //	ta.FirstName and ta.LastName are unchanged.
            //	mickey.FirstName is "Ex-Instructor" and mickey.LastName is "Ashes".
            //	instructor.FirstName and instructor.LastName are unchanged.

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
