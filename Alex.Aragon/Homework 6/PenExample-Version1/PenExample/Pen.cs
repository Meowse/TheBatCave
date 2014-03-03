using System;
using System.Dynamic;
using System.Linq.Expressions;

namespace PenExample
{
    public class Pen
    {

        public int DryingTimeInMinutes{ get; set; }
        public bool Capped { get; set; }

        public Pen()
        {
            Capped = true;
            DryingTimeInMinutes = 30;
        }
        public void MinutesPass(int minutes)
        {
            DryingTimeInMinutes -= minutes;
            //throw new System.NotImplementedException();
        }

        public void Write(string something)
        {
            // TODO: Optionally age your pen here based on time and ink consumption.

        }

    }
}
