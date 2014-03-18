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
            //                Description = "Expensive Ballpoint Pen";
            //            }
            //            Description = "$" + priceInDollars + " Ballpoint Pen";
            Description = string.Format("${0} Ballpoint Pen", priceInDollars);


            DryingTimeInMinutes = priceInDollars*24*60;
        }
    }
}
