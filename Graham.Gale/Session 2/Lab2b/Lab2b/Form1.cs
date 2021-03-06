﻿using System;
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
            // eva.FirstName should be Eva-Lise and eva.LastName should be Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName should be Eva and ta.LastName should be Carlstrom
            // Got this wrong, I guess ta is a reference to eva 
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName should be Michael and mickey.LastName Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName should be Michael and instructor.LastName should be Phoenix

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            //  * What are eva.FirstName and eva.LastName?
            // eva.FirstName should be Eva-Lise and eva.LastName should be Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName should be Eva-Lise and ta.LastName should be Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName should be Mickey and mickey.LastName Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName should be Mickey and instructor.LastName should be Phoenix


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
            //  * What are eva.FirstName and eva.LastName?
            // eva.FirstName should be The Very Helpful Eva-Lise and eva.LastName should be Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName should be The Very Helpful Eva-Lise and ta.LastName should be Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName should be The Also Helpful Michael and mickey.LastName Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName should be The Also Helpful Michael and instructor.LastName should be Phoenix

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...
            //  * What are eva.FirstName and eva.LastName?
            // eva.FirstName should be The Very Helpful Eva-Lise and eva.LastName should be Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName should be The Very Helpful Eva-Lise and ta.LastName should be Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName should be The Also Helpful Michael and mickey.LastName Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName should be Very Helpful Eva-Lise and instructor.LastName should be Carlstrom

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...
            //  * What are eva.FirstName and eva.LastName?
            // eva.FirstName should be The Very Helpful Eva-Lise and eva.LastName should be Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            // ta.FirstName should be The Very Helpful Eva-Lise and ta.LastName should be Carlstrom
            //  * What are mickey.FirstName and mickey.LastName?
            // mickey.FirstName should be Ex-Instructor and mickey.LastName Ashes
            //  * What are instructor.FirstName and instructor.LastName?
            // instructor.FirstName should be Very Helpful Eva-Lise and instructor.LastName should be Carlstrom

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
