using ExploringCSharp;
using NUnit.Framework;

namespace ExploringCSharpTest
{
    [TestFixture]
    public class CombiningStringsExtraCreditTest
    {
        [Test]
        public void GreetsByCombiningStringsWithStringBuilderWorks()
        {
            // I believe this is what you had intended.  <insert smiley face here>
            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithStringBuilder("Mickey"), Is.EqualTo("Hello, Mickey"));
        }
    }
}
