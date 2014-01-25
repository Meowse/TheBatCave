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
        // ******* All my predictions are listed in each of the buttons, I have a write up of my comparisons at the very buttom*****

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
            //  * What are eva.FirstName and eva.LastName? (Pre-compile) eva.FirstName is Eva-Lise, eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName? (Pre-compile) ta.FirstName is Eva-Lise, ta.LastName is Carlstrom
            /* What are mickey.FirstName and mickey.LastName? 
             * (My prediction) 
             * mickey.FirstName is Michael, mickey.LastName is Phoenix, if the fixMickeyNameButton was clicked on mickey.FirstName will be Mickey, 
             * if the mickeyShameNameChangeButton was clicked mickey.FirstName will be Ex-Instructor and mickey.LastName will be Ashes
             */
            //  * What are instructor.FirstName and instructor.LastName? (Pre-compile) instructor.FirstName is Michael, instructor.LastName is Phoenix

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            /*(My predictions) 
             * mickey.FirstName will be Mickey and mickey.LastName will be Phoenix,
             * or mickey.LastName will be Ashes if the mickeyShameNameChangeButton was clicked on prior to clicking fixMickeyNameButton
             * instructor.FirstName will be Mickey and instructor.LastName will be Phoenix, or instructor.LastName can be Ashes if mickeyShameNameChangeButton was clicked at any point
             * If the fixEvaNameButton was not clicked, eva.FirstName will be Eva and eva.LastName will be Carlstrom
             * If the fixEvaNameButton was clicked, eva.FirstName will be Eva-Lise and eva.LastName will be Carlstrom
            */
            RedisplayNames();
        }

        private void askForHelpButton_Click(object sender, EventArgs e)
        {
            // 3) Ask first the TA, and then the instructor, for help
            Person personToAskForHelp = ta;
            personToAskForHelp.FirstName = "The Very Helpful " + personToAskForHelp.FirstName;
            personToAskForHelp = instructor;
            personToAskForHelp.FirstName = "The Also Helpful " + personToAskForHelp.FirstName;

            /* Same questions... 
             * (My predictions)  
             * If the fixEvaNameButton and fixMickeyNameButton were both clicked on, it will display The Very Helpful Eva-Lise and then The Also Helpful Mickey
             * if the fixEvaNameButton and fixMickeyNameButton were both NOT clicked on, it will display The Very Helpful Eva and then The Also Helpful Michael
             * if the fixEvaNameButton was clicked on and fixMickeyNameButton was NOT clicked on, it will display The Very Helpful Eva-Lise and then Also Helpful Michael
             * if the fixEvaNameButton was NOT clicked and fixMickeyNameButton was clicked, it will display The Very Helpful Eva and then The Also Helpful Mickey
             */

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            /* Same questions...
             * (My predictions) 
             * if the fixEvaNameButton was clicked instructor.FirstName will be Eva-Lise and instructor.LastName will be Carlstrom
             * if the fixEvaNamebutton was not clicked instructor.FirstName will be Eva and instructor.LastName will be Carlstrom
             * mickey.FirstName will be Michael if theFixMickeyNameButton was not clicked, mickey.FirstName will be Mickey if theFixMickeyNameButton was clicked, mickey.FirstName will be Ex-Instructor if the mickeyShameNameChangeButton was clicked
             * mickey.LastName will be Phoenix or it will be Ashes if mickeyShameNameChangeButton was clicked
            */
            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            /* Same questions... 
             * (My predictions) 
             * mickey.FirstName will be Ex-Instructor, mickey.LastName will be Ashes.
             * if the fixMickeyNameButton was clicked after clicking mickeyShameNameChangeButton mickey.FirstName will change to Mickey and mickey.LastName will stay as Ashes
             * eva.LastName will be Carlstrom
             * eva.FirstName will be Eva-Lise if the fixEvaNameButton was clicked or Eva if the fixEvaNameButton was NOT clicked
             */

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
