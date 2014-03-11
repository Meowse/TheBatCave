namespace PenExample
{
    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            // TODO: Figure out the right way to get rid of the comment
            // on the next line. (not clear on this? assumed it wasn't just deleting comment; changed code to make comment extraneous)
            int hours = 5;
            DryingTimeInMinutes = 60*hours;
        }
    }
}
