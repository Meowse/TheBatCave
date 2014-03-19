using System;

namespace PenExample
{
    public class BallPointPen : Pen
    {
        public BallPointPen(int priceInDollars)
        {
            if (priceInDollars < 0)
            {
                throw new Exception("The pen's price must be a positive integer."); 
            }

            Description = priceInDollars < 20 
                ? "a cheap Ball Point Pen" 
                : "an expensive Ball Point Pen";

            DryingTimeInMinutes = priceInDollars*24*60;
        }
    }
}
