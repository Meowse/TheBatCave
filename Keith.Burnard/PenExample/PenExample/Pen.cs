namespace PenExample
{
    public class Pen
    {
        protected int DryingTimeRemainingInMinutes { get; set; }

        public bool PenIsDry { get; private set; }

        public bool Capped { get; set; }

        public void MinutesPass(int minutes)
        {
            // Age your pen here.

            DryingTimeRemainingInMinutes -= minutes;
            if (DryingTimeRemainingInMinutes <= 0)
            {
                PenIsDry = true;
            }
        }

        public void Write(string something)
        {
            // Optionally age your pen here based on time and ink consumption.
            DryingTimeRemainingInMinutes -= something.Length;
        }

    }

    public class FeltTipPen : Pen
    {
        public FeltTipPen()
        {
            Capped = true;
            DryingTimeRemainingInMinutes = 30;
        }
    }

    public class BallPointPen : Pen
    {
        public BallPointPen(int dryingTimeInHours)
        {
            Capped = true;
            DryingTimeRemainingInMinutes = dryingTimeInHours * 60;
        }
    }
}
