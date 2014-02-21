namespace PenExample
{
    public class Pen
    {
        protected int DryingTimeInMinutes { get; set; }

        public bool Capped { get; set; }

        public void MinutesPass(int minutes)
        {
            // TODO: Age your pen here.
            throw new System.NotImplementedException();
        }

        public void Write(string something)
        {
            // TODO: Optionally age your pen here based on time and ink consumption.
        }
    }
}
