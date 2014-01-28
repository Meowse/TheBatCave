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
        //

        private Person instructor;
        private Person mickey;
        private Person ta;
        private Person eva;
        private Person askEvaForHelp = new Person();
        private Person askInstructorForHelp = new Person();
        private Person askMickeyForHelp = new Person();

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

            RedisplayNames();
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";
            mickey.LastName = "Phoenix"; 

            RedisplayNames();
        }

        private void askForHelpButton_Click(object sender, EventArgs e)
        {
            // 3) Ask first the TA, and then the instructor, for help
            askEvaForHelp.FirstName = "The Very Helpful " + ta.FirstName;
            askEvaForHelp.LastName = eva.LastName;

            //ask Mickey for help
            askMickeyForHelp.FirstName = "The Also Helpful " + mickey.FirstName;
            askMickeyForHelp.LastName = mickey.LastName;

            //person who is the instructor right now
            askInstructorForHelp.FirstName = "The Also Helpful " + instructor.FirstName;
            askInstructorForHelp.LastName = instructor.LastName;


            updateAskForHelpButtonLabels();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            mickeyName.Text = "Your instructor is now " + eva.FirstName + " " + eva.LastName;
            instructor = ta;
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";
            if (instructor == ta)
            {
                mickeyName.Text = "Your old instructor's name changed to " + mickey.FirstName + " " + mickey.LastName;
            }
            else
            {
                RedisplayNames();
            }
        }

        private void RedisplayNames()
        {
            evaName.Text = eva.FirstName + " " + eva.LastName;
            taName.Text = ta.FirstName + " " + ta.LastName;
            mickeyName.Text = mickey.FirstName + " " + mickey.LastName;
            instructorName.Text = instructor.FirstName + " " + instructor.LastName;
        }

        private void updateAskForHelpButtonLabels()
        {
            evaName.Text = askEvaForHelp.FirstName + " " + askEvaForHelp.LastName;
            taName.Text = askEvaForHelp.FirstName + " " + askEvaForHelp.LastName;
            instructorName.Text = askInstructorForHelp.FirstName + " " + askInstructorForHelp.LastName;
            mickeyName.Text = askMickeyForHelp.FirstName + " " + askMickeyForHelp.LastName;
            if (instructor == ta)
            {
                mickeyName.Text = "Please refer questions to " + eva.FirstName + " " + eva.LastName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
