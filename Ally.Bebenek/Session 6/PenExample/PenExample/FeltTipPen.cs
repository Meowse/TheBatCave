namespace PenExample
{
    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            // DONE: Figure out the right way to get rid of the comment
            // on the next line.
            int hours = 5;
            DryingTimeInMinutes = 60 * hours;
            Description = "You have got Felt Tip Pen";
        }
    }
}
