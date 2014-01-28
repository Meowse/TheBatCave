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
            //  * What are eva.FirstName and eva.LastName? (My prediction) eva.FirstName is Eva-Lise, eva.LastName is Carlstrom
            //  * What are ta.FirstName and ta.LastName? (My prediction) ta.FirstName is Eva-Lise, ta.LastName is Carlstrom
            /* What are mickey.FirstName and mickey.LastName? (My prediction)mickey.FirstName is Michael, mickey.LastName is Phoenix, if the fixMickeyNameButton was clicked on mickey.FirstName will be Mickey, if the mickeyShameNameChangeButton was clicked mickey.FirstName will be Ex-Instructor and mickey.LastName will be Ashe
             * What are instructor.FirstName and instructor.LastName? (My prediction) instructor.FirstName is Michael, instructor.LastName is Phoenix*/
            RedisplayNames();
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.
            /*(My predictions)
             * What are eva.FirstName and eva.LastName? (My prediction) eva.FirstName is Eva-Lise, eva.LastName is Carlstrom
             * What are ta.FirstName and ta.LastName? (My prediction) ta.FirstName is Eva-Lise, ta.LastName is Carlstrom
             * What are mickey.FirstName and mickey.LastName? (My prediction) mickey.FirstName will be Mickey and mickey.LastName will be Phoenix,or mickey.LastName will be Ashes if the mickeyShameNameChangeButton was clicked on prior to clicking fixMickeyNameButton
             * What are instructor.FirstName and instructor.LastName? (My prediction) instructor.FirstName will be Mickey and instructor.LastName will be Phoenix, or instructor.LastName can be Ashes if mickeyShameNameChangeButton was clicked at any point
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
             * What are eva.FirstName and eva.LastName? (My prediction) If the fixEvaNameButton, it will display The Very Helpful Eva-Lise Carlstrom
             * What are ta.FirstName and ta.LastName? (My prediction) If the fixEvaNameButton was clicked on, it will display The Very Helpful Eva-Lise Carlstrom
             * What are mickey.FirstName and mickey.LastName? (My prediction) if the fixEvaNameButton and fixMickeyNameButton were both NOT clicked on, it will display The Also Helpful Michael Phoenix. If the fixEvaNameButton was clicked on and fixMickeyNameButton was NOT clicked on, then Also Helpful Michael Phoenix
             * What are instructor.FirstName and instructor.LastName? (My predictions)
             * if the fixEvaNameButton and fixMickeyNameButton were both NOT clicked on, it will display The Very Helpful Eva Carlstrom
             * if the fixEvaNameButton was clicked on and fixMickeyNameButton was NOT clicked on, it will display The Very Helpful Eva-Lise Carlstrom
             * if the fixEvaNameButton was NOT clicked and fixMickeyNameButton was clicked, it will display The Very Helpful Eva Carlstrom and then The Also Helpful Mickey Phoenix
             */

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            /* Same questions...
             * (My predictions) 
             * What are eva.FirstName and eva.LastName? (My prediction) eva.FirstName is Eva-Lise, eva.LastName is Carlstrom if the fixEvaNameButton was pressed eva.FirstName is Eva-Lise and eva.LastName is Carlstrom
             * What are ta.FirstName and ta.LastName? (My prediction) ta.FirstName is Eva-Lise, ta.LastName is Carlstrom
             * What are mickey.FirstName and mickey.LastName? (My prediction)
             * mickey.FirstName will be Michael if theFixMickeyNameButton was not clicked, mickey.FirstName will be Mickey if theFixMickeyNameButton was clicked, mickey.FirstName will be Ex-Instructor if the mickeyShameNameChangeButton was clicked
             * mickey.LastName will be Phoenix or it will be Ashes if mickeyShameNameChangeButton was clicked
             * What are instructor.FirstName and instructor.LastName? (My predictions) if the fixEvaNamebutton was not clicked instructor.FirstName will be Eva and instructor.LastName will be Carlstrom
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
             * What are eva.FirstName and eva.LastName? (My prediction) eva.FirstName is Eva-Lise, eva.LastName is Carlstrom if the fixEvaNameButton was pressed eva.FirstName is Eva-Lise and eva.LastName is Carlstrom 
             * What are ta.FirstName and ta.LastName? (My predicdtion) ta.FirstName is Eva-Lise, ta.LastName is Carlstrom if the fixEvaNameButton was pressed ta.FirstName is Eva-Lise and ta.LastName is Carlstrom
             * mickey.FirstName will be Ex-Instructor, mickey.LastName will be Ashes. If the fixMickeyNameButton was clicked after clicking mickeyShameNameChangeButton mickey.FirstName will change to Mickey and mickey.LastName will stay as Ashes
             * What are instructor.FirstName and instructor.LastName? (My predictions)  instructor.FirstName is Eva-Lise, instructor.LastName is Carlstrom if the fixEvaNameButton was pressed instructor.FirstName is Eva-Lise and instructor.LastName is Carlstrom
             */
        }

        private void RedisplayNames()
        {
            evaName.Text = eva.FirstName + " " + eva.LastName;
            taName.Text = ta.FirstName + " " + ta.LastName;
            mickeyName.Text = mickey.FirstName + " " + mickey.LastName;
            instructorName.Text = instructor.FirstName + " " + instructor.LastName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
    /*
     * My predictions were fairly close, but not perfect. I did not take into account of what would happen if askForHelpButton was clicked on and how that would effect the RedisplayNames() method.
     * If the askForHelpButton is hit multiple times, the labels will keep printing The Very Helpful The Also Helpful with Eva or Eva-Lise followed by Carlstrom or The Also Helpful The Very Helpful followed by Michael, Mickey or Ex-Instructor followed by either Phoenix or Ashes.
     * The program will always display mickey.LastName as Ashes if the mickeyShameNameButton is clicked and there is no way to revert mickey.LastName to Pheonix.
     * The fixMickeyNameButton needs to include a mickey.LastName = Phoenix, otherwise if the mickeyShameNameChangeButton is clicked first, hitting the fixMickeyNameButton will result in Mickey Ashe (unless that was the actual intent of the developer).
     */
}
