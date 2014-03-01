namespace PenExample
{
    public class BallPointPen : Pen
    {
        public BallPointPen(int priceInDollars)
        {
            DryingTimeInMinutes = priceInDollars*24*60;
            TimeLeft = DryingTimeInMinutes;
            Description = "Ball Point Pen will last for";
        }
    }
}
