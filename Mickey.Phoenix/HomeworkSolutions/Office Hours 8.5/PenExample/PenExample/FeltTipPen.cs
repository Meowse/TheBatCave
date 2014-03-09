namespace PenExample
{
    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            Description = "Felt-tip Pen";

            // TODO: Figure out the right way to get rid of the comment
            // on the next line.
            DryingTimeInMinutes = 60*5; // 5 hours
        }
    }
}
