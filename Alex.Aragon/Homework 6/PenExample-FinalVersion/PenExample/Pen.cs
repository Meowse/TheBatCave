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
        protected int DryingTimeInMinutes { get; set; }

        public bool Capped { get; set; }

        //TODO: Implement the description so that the different kinds of
        // pens describe themselves accurately.
        public string Description { get; protected set; }

        // TODO: Remember that pens only dry out while uncapped.
        public void MinutesPass(int minutes)
        {
            // TODO: Age your pen here.
            //throw new System.NotImplementedException();
            DryingTimeInMinutes -= minutes;
        }

        // TODO: Implement this to report any errors with MessageBox.Show().
        // TODO: This method is expected to return the text that is actually
        // "written".
        public string Write(string something)
        {
            if (this.Capped)
            {
                MessageBox.Show("You need to uncap your pen before you write.");
                return null;
            }
            else
            {
                if (DryingTimeInMinutes < 0)
                {
                    MessageBox.Show("Your pen is out of ink");
                    return null;
                }
                if (string.IsNullOrEmpty(something))
                {
                    MessageBox.Show("Enter text in text field");
                    return null;
                }
                MinutesPass(1);
                return something;
            }
        }
            // TODO: Optionally age your pen here based on time and ink consumption.
        }
    }
