namespace PenExample
{
    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            Description = "a felt tip pen";

            // TODO: Figure out the right way to get rid of the comment
            // on the next line.
            DryingTimeInMinutes = 60*5; // 5 hours
        }
    }
}
