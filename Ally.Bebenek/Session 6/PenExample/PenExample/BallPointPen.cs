namespace PenExample
{
    public class BallPointPen : Pen
    {
        public BallPointPen(int priceInDollars)
        {
            DryingTimeInMinutes = priceInDollars*24*60;

            if (priceInDollars < 5)
                Description = "You have got Cheap Ball Tip Pen";
            else Description = "You have got Expensive Ball Tip Pen";
        }
    }
}
