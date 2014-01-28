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
            //** eva.FirstName is Eva-Lise and eva.LastName is Carlstrom

            //  * What are ta.FirstName and ta.LastName?
            //**ta.FirstName is Eva-Lise and ta.LastName is Carlstrom

            //  * What are mickey.FirstName and mickey.LastName?
            //** mickey.FirstName is Michael and mickey.LastName is Phoenix

            //  * What are instructor.FirstName and instructor.LastName?
            //** instructor.FirstName is Michael and instructor.LastName is Phoenix
            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            // Same questions as before.


            //  * What are eva.FirstName and eva.LastName?
            //** eva.FirstName is Eva-Lise and eva.LastName is Carlstrom

            //  * What are ta.FirstName and ta.LastName?
            //**ta.FirstName is Eva-Lise and ta.LastName is Carlstrom

            //  * What are mickey.FirstName and mickey.LastName?
            //** mickey.FirstName is Mickey and mickey.LastName is Phoenix

            //  * What are instructor.FirstName and instructor.LastName?
            //** instructor.FirstName is Mickey and instructor.LastName is Phoenix


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
            //** eva.FirstName is The Very Helpful Eva-Lise and eva.LastName is Carlstrom

            //  * What are ta.FirstName and ta.LastName?
            //**ta.FirstName is The Very Helpful Eva-Lise and ta.LastName is Carlstrom

            //  * What are mickey.FirstName and mickey.LastName?
            //** mickey.FirstName is The Also Helpful Mickey and mickey.LastName is Phoenix

            //  * What are instructor.FirstName and instructor.LastName?
            //** instructor.FirstName is "The Also Helpful Mickey and instructor.LastName is Phoenix

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Same questions...

            //  * What are eva.FirstName and eva.LastName?
            //** eva.FirstName is The Very Helpful Eva-Lise and eva.LastName is Carlstrom

            //  * What are ta.FirstName and ta.LastName?
            //**ta.FirstName is The Very Helpful Eva-Lise and ta.LastName is Carlstrom

            //  * What are mickey.FirstName and mickey.LastName?
            //** mickey.FirstName is The Very Helpful Eva-Lise and mickey.LastName is Carlstrom
            //*** I was wrong here because I thought that since instructor pointed to mickey that a change to instructor would also change mickey.
       

            //  * What are instructor.FirstName and instructor.LastName?
            //** instructor.FirstName is The Very Helpful Eva-Lise and instructor.LastName is Carlstrom

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Same questions...

            //  * What are eva.FirstName and eva.LastName?
            //** eva.FirstName is Ex-Instructor and eva.LastName is Ashes
            //*** I was wrong here because I thought that since mickey pointed to instructor and instructor pointed to ta and ta pointed to eva that all the variables would change when mickey.firtname and mickey.lastname changed. 
            
            //  * What are ta.FirstName and ta.LastName?
            //**ta.FirstName is Ex-Instructor and ta.LastName is Ashes
            //*** I was wrong here because I thought that since mickey pointed to instructor and instructor pointed to ta and ta pointed to eva that all the variables would change when mickey.firtname and mickey.lastname changed.
            
            //  * What are mickey.FirstName and mickey.LastName?
            //** mickey.FirstName is Ex-Instructor and mickey.LastName is Ashes
            

            //  * What are instructor.FirstName and instructor.LastName?
            //** instructor.FirstName is Ex-Instructor and instructor.LastName is Ashes
            //*** I was wrong here because I thought that since mickey pointed to instructor and instructor pointed to ta and ta pointed to eva that all the variables would change when mickey.firtname and mickey.lastname changed.
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

//* Extra Credit Predict what will happen when you click the buttons out of order.  Compare your
//*predictions to reality.

//** Event handlers execute when the button is clicked, so if the button is not clicked then the event handler doesn't execute and the 
//** variable references don't change. For example, if we skipped over or didn't click on the first button and clicked directly on the 
//** second button eva.FirstName as well as ta.firstName would still equal eva. This is becuase we have skipped over the event on the first 
//** click, i.e. the event which changes eva.firstname to Eva-Lise (consequently changing the value of eva.Firstname and ta.firstName, because ta = eva)
//** However, mickey.firstName and instructor.firstName would still change from Michael to Mickey because that change was executed on the click of the second button. 
 