namespace PenExample
{
    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            // TODO: Figure out the right way to get rid of the comment
            // on the next line.
            Capped = true;
            DryingTimeInMinutes = 60*5; // 5 hours
            Description = "You have a Felt Tip Pen";
        }
    }
}
