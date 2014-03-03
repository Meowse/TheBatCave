namespace PenExample
{
    public class BallPointPen : Pen
    {
        public BallPointPen(int priceInDollars)
        {
            Capped = true;
            DryingTimeInMinutes = priceInDollars*24*60;
            if (priceInDollars == 1)
                Description = "You have a Cheap Ball Point Pen";
            else
                Description = "You have an Expensive Ball Point Pen";
        }
    }
}
