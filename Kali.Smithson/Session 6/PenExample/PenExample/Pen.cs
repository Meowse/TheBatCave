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

        public object MessageBox { get; set; }

        // TODO: Implement the description so that the different kinds of
        // pens describe themselves accurately.
        public string Description { get; protected set; }

        // TODO: Remember that pens only dry out while uncapped.
        public void MinutesPass(int minutes)
        {
            // TODO: Age your pen here.
            throw new System.NotImplementedException();
        }

        // TODO: Implement this to report any errors with MessageBox.Show().
        // TODO: This method is expected to return the text that is actually
        // "written".
        public string Write(string something)
        {
            // TODO: Optionally age your pen here based on time and ink consumption.
            return null;
        }
    }
}
