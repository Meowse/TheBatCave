﻿namespace PenExample
{
    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            // TODO: Figure out the right way to get rid of the comment
            // on the next line.
            DryingTimeInMinutes = 60*5;
            TimeLeft = DryingTimeInMinutes;
            Description = "You bought a felt tip pen, it will last for";
        }
    }
}