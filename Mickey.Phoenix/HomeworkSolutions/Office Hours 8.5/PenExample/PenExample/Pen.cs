using System.Windows.Forms;

namespace PenExample
{
    // DONE: Throughout this class, report errors (such as trying to 
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
        protected int MinutesOfInkLeft { get; set; }

        private bool _isCapped = true;

        public bool IsCapped
        {
            get { return _isCapped; }
            set
            {
                if (_isCapped && value)
                {
                    MessageBox.Show("Pen is already capped.");
                    return;
                }
                if (!_isCapped && !value)
                {
                    MessageBox.Show("Pen is already uncapped.");
                    return;
                }
                _isCapped = value;
            }
        }

        // DONE: Implement the description so that the different kinds of
        // pens describe themselves accurately.
        private string _description;

        public string Description
        {
            get
            {
                if (IsCapped)
                {
                    return _description + " (capped)";
                }
                else
                {
                    return _description + " (uncapped)";
                }
            }
            protected set { _description = value; }
        }

        // DONE: Remember that pens only dry out while uncapped.
        public void MinutesPass(int minutes)
        {
            if (!IsCapped)
            {
                // DONE: Age your pen here.
                MinutesOfInkLeft = MinutesOfInkLeft - minutes;
            }
        }

        // DONE: Implement this to report any errors with MessageBox.Show().
        // DONE: This method is expected to return the text that is actually "written".
        // TODO: Optionally age your pen here based on time and ink consumption.
        public string Write(string textToWrite)
        {
            if (IsCapped)
            {
                MessageBox.Show("Your pen is capped.");
                return null;
            }
            if (MinutesOfInkLeft <= 0)
            {
                MessageBox.Show("Your pen has dried out.  Please buy a new pen!");
                return null;
            }
            return textToWrite;
        }
    }
}
