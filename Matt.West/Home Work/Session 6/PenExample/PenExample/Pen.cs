using System.Runtime.Serialization.Formatters;
using System.Windows.Forms;

namespace PenExample
{
    // TODO: Throughout this class, report errors (such as trying to 
    // cap an already capped pen) with MessageBox.Show().  
    //
    // WARNING: This is bad programming style, since the pen 
    // shouldn't actually be doing stuff to the UI, but
    // it's standing in place of "proper error handling" in this
    // classroom example.
    //
    // TODO: Consider how much harder it makes to test the code.  :-)
    public class Pen
    {
        public int DryingTimeInMinutes { get; set; }
        public bool Capped { get; set; }

        // TODO: Implement the description so that the different kinds of
        // pens describe themselves accurately.
        public string Description { get; protected set; }

        

        // TODO: Remember that pens only dry out while uncapped.
        public void MinutesPass(int minutes)
        {
            // TODO: Age your pen here.
            if (Capped == false)
            {
                DryingTimeInMinutes = DryingTimeInMinutes - minutes;
                if (DryingTimeInMinutes <= 0)
                {
                    MessageBox.Show("Your pen has dried up and must be replaced.");
                }
            }
            else DryingTimeInMinutes = DryingTimeInMinutes; 
        }

        // TODO: Implement this to report any errors with MessageBox.Show().
        // TODO: This method is expected to return the text that is actually
        // "written".
        public string Write(string something)
        {
            if (DryingTimeInMinutes > 0 && Capped == false )
            {
                something = "All work and no play makes Jack a very boring boy.";
                DryingTimeInMinutes = DryingTimeInMinutes - 1;
                return something;
            }
                // TODO: Optionally age your pen here based on time and ink consumption.
            else
            {
                if (DryingTimeInMinutes <= 0)
                {
                    MessageBox.Show("Your pen has dried up and must be replaced.");
                    return null;
                }
                else
                {
                    MessageBox.Show("You must un-cap your pen to write.");
                    return null;
                }

            };
        }
    }
}
