using System.Diagnostics;
using NUnit.Framework;
using PenExample;

namespace WritingDesk
{
    class PenExampleTest
    {
        private readonly FeltTipPen _feltTipPen = new FeltTipPen();
        private readonly BallPointPen _inexpensiveBallPointPen = new BallPointPen(1);
        private readonly BallPointPen _expensiveBallPointPen = new BallPointPen(20);

        [Test]
        public void TestFeltTipPen()
        {
            Assert.That(_feltTipPen.Capped, Is.EqualTo(true));
            Assert.That(_feltTipPen.PenIsDry, Is.EqualTo(false));
            _feltTipPen.Capped = false;
            _feltTipPen.MinutesPass(5);
            Assert.That(_feltTipPen.PenIsDry, Is.EqualTo(false));
            _feltTipPen.Write("12345");
            Assert.That(_feltTipPen.PenIsDry, Is.EqualTo(false));
            _feltTipPen.MinutesPass(20);
            Assert.That(_feltTipPen.PenIsDry, Is.EqualTo(true));
        }
    }
}
