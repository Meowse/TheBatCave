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
            //Explanation  for wrong answers: I thought the program would make a copy of the information stored in the object. But instead it looks like the objects are pointing to data.
            //So when data changes, it changes it for all objects pointing to the same data. Which is why eva.FirstName and ta.FirstName are the same after the first click, 


            // 1) Fix Eva's name
            eva.FirstName = "Eva-Lise";

            // Questions:
            //  * What are eva.FirstName and eva.LastName?
            //    eva.FirstName = Eva-Lise, eva.LastName = Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            //    ta.FirstName = Eva, ta.LastName = Carlstrom //Wrong: should be ta.FirstName = Eva-Lise
            //  * What are mickey.FirstName and mickey.LastName?
            //    mickey.FirstName = Michael, mickey.LastName = Phoenix  
            //  * What are instructor.FirstName and instructor.LastName?
            //    instructor.FirstName = Michael, instructor.LastName = Phoenix

            RedisplayNames();            
        }

        private void fixMickeyNameButton_Click(object sender, EventArgs e)
        {
            // 2) Fix Mickey's name
            mickey.FirstName = "Mickey";

            // Questions:
            //   * What are eva.FirstName and eva.LastName?
            //    eva.FirstName = Eva-Lise, eva.LastName = Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            //    ta.FirstName = Eva, ta.LastName = Carlstrom  //Wrong: should be ta.FirstName = Eva-Lise
            //  * What are mickey.FirstName and mickey.LastName?
            //    mickey.FirstName = Mickey, mickey.LastName = Phoenix
            //  * What are instructor.FirstName and instructor.LastName?
            //    instructor.FirstName = Michael, instructor.LastName = Phoenix  //Wrong: should be  instructor.FirstName = Mickey

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
            //   * What are eva.FirstName and eva.LastName?
            //    eva.FirstName = Eva-Lise, eva.LastName = Carlstrom //Wrong: should be eva.FirstName = The Very Helpful Eva-Lise
            //  * What are ta.FirstName and ta.LastName?
            //    ta.FirstName = Eva, ta.LastName = Carlstrom //Wrong: should be ta.FirstName = The Very Helpful Eva-Lise
            //  * What are mickey.FirstName and mickey.LastName?
            //    mickey.FirstName = Mickey, mickey.LastName = Phoenix //Wrong: should be mickey.FirstName = The Also Helpful Mickey
            //  * What are instructor.FirstName and instructor.LastName?
            //    instructor.FirstName = Michael, instructor.LastName = Phoenix //Wrong: should be instructor.FirstName = The Also Helpful Mickey

            RedisplayNames();
        }

        private void giveMickeyMartianMeaslesButton_Click(object sender, EventArgs e)
        {
            // 4) Mickey gets the Martian Measles, and Eva takes over as teacher for the class.
            instructor = ta;

            // Questions:
            //   * What are eva.FirstName and eva.LastName?
            //    eva.FirstName = Eva-Lise, eva.LastName = Carlstrom //Wrong: should be eva.FirstName = The Very Helpful Eva-Lise
            //  * What are ta.FirstName and ta.LastName?
            //    ta.FirstName = Eva, ta.LastName = Carlstrom //Wrong ta.FirstName = The Very Helpful Eva-Lise
            //  * What are mickey.FirstName and mickey.LastName?
            //    mickey.FirstName = Mickey, mickey.LastName = Phoenix //Wrong: should be mickey.FirstName = The Also Helpful Mickey
            //  * What are instructor.FirstName and instructor.LastName?
            //    instructor.FirstName = Eva, instructor.LastName = Carlstrom //Wrong: should be mickey.FirstName =  The Very Helpful Eva-Lise instructor.LastName = Carlstrom 

            RedisplayNames();
        }

        private void mickeyShameNameChangeButton_Click(object sender, EventArgs e)
        {
            // 5) In shame, Mickey changes his name to "Ex-Instructor Ashes"
            mickey.FirstName = "Ex-Instructor";
            mickey.LastName = "Ashes";

            // Questions:
            //   * What are eva.FirstName and eva.LastName?
            //    eva.FirstName = Eva-Lise, eva.LastName = Carlstrom
            //  * What are ta.FirstName and ta.LastName?
            //    ta.FirstName = Eva, ta.LastName = Carlstrom //Wrong ta.FirstName = The Very Helpful Eva-Lise
            //  * What are mickey.FirstName and mickey.LastName?
            //    mickey.FirstName = Ex-Instructor, mickey.LastName = Ashes
            //  * What are instructor.FirstName and instructor.LastName?
            //    instructor.FirstName = Eva, instructor.LastName = Carlstrom //Wrong instructor.FirstName = The Very Helpful Eva-Lise

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
