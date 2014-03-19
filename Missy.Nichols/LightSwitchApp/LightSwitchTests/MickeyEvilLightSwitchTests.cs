using LightSwitch;
using NUnit.Framework;

namespace LightSwitchTests
{
    [TestFixture]
    public class MickeyEvilLightSwitchTests
    {
        [Test]
        public void LightSwitchStartsOffDimmedToZeroAndOff()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.DimmestDimmerValue));
        }

        [Test]
        public void DimmerSetToZeroCannotTurnOnWithSingleClick()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.ClickBigButton();
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(0));
            lightSwitch.ClickBigButton();
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(0));
        }

        [Test]
        public void DimmerSetToZeroCanTurnOnWithDoubleClick()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.DoubleClickBigButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.DimmestDimmerValue));
            lightSwitch.ClickBigButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.DimmestDimmerValue));
        }

        [Test]
        public void DimmerSetToZeroIsNotOverriddenByDoubleClick()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.DoubleClickBigButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.DimmestDimmerValue));
            lightSwitch.ClickBigButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.DimmestDimmerValue));
            lightSwitch.ClickBigButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.DimmestDimmerValue));
        }

        [Test]
        public void IntensityAndDimmerValuesNotBeingOverridden()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.ClickBigButton();
            lightSwitch.ClickUpButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(1));
            lightSwitch.ClickBigButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickBigButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(1));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(2));
        }

        [Test]
        public void DimmerUpDoesNotTurnsLightOnAndDimmerValuesIncreases()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.ClickUpButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(1));
            lightSwitch.ClickUpButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(2));
        }

        [Test]
        public void DimmerUpExcessiveTimesOnlyBrightensLightToMax()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.DoubleClickBigButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickUpButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue));
            //Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue));
        }

        [Test]
        public void DimmerDownOnlyDimsLightToMin()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.ClickDownButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(0));
        }

        [Test]
        public void DimmerUpThenDownTurnsLightOff()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.ClickUpButton();
            lightSwitch.ClickDownButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(0));
            Assert.That(lightSwitch.DimmerValue, Is.EqualTo(0));
        }

        [Test]
        public void DoubleClickThenDimmerDownSetsDimmerValueToMaxMinusOne()
        {
            var lightSwitch = new MickeyEvilLightSwitch();
            lightSwitch.DoubleClickBigButton();
            lightSwitch.ClickDownButton();
            Assert.That(lightSwitch.PhysicalLightBrightness, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue - 1));
            //Assert.That(lightSwitch.DimmerValue, Is.EqualTo(MickeyEvilLightSwitch.BrightestDimmerValue - 1));
        }

        // TODO: Add or change tests as necessary to replicate the ACTUAL behavior of
        // the real light switches, to wit:
        // The LEDs only display the current DimmerValue if the light is off.
        // If the light is on, the LEDs display the current intensity of the light.
        // Thus, DimmerValue should NOT be public -- instead, we should have a 
        // public get/private set property called "IntensityLedValue" or some such.
        // Have fun!
    }
}
