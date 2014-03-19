namespace PenExample
{
    public class BallPointPen : Pen
    {
        public BallPointPen(int priceInDollars)
        {
//            if (priceInDollars < 5)
//            {
//                Description = "Cheap Ballpoint Pen";
//            }
//            else
//            {
//                Description = "Expensive Ballpoint pen";
//            }
            DryingTimeInMinutes = priceInDollars*24*60;
            Description = string.Format("${0} Ballpoint pen, that is ", priceInDollars);
        }
    }
}
