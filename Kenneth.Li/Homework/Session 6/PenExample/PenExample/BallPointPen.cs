namespace PenExample
{
    public class BallPointPen : Pen
    {
        public BallPointPen(int priceInDollars)
        {
            DryingTimeInMinutes = priceInDollars*24*60;
        }
    }
}
