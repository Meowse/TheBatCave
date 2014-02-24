using System.Diagnostics;
using NUnit.Framework;
using PenExample;

namespace WritingDesk
{
    class PenExampleTest
    {
        private readonly FeltTipPen _feltTipPen = new FeltTipPen();
        private readonly BallPointPen _ballPointPen = new BallPointPen(1);

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

        [Test]
        public void TestBallPointPen()
        {
            Assert.That(_ballPointPen.Capped, Is.EqualTo(true));
            Assert.That(_ballPointPen.PenIsDry, Is.EqualTo(false));
            _ballPointPen.Capped = false;
            _ballPointPen.MinutesPass(5);
            Assert.That(_ballPointPen.PenIsDry, Is.EqualTo(false));
            _ballPointPen.Write("12345");
            Assert.That(_ballPointPen.PenIsDry, Is.EqualTo(false));
            _ballPointPen.MinutesPass(20);
            Assert.That(_ballPointPen.PenIsDry, Is.EqualTo(false));
            _ballPointPen.MinutesPass(60);
            Assert.That(_ballPointPen.PenIsDry, Is.EqualTo(true));
        }
    }
}
