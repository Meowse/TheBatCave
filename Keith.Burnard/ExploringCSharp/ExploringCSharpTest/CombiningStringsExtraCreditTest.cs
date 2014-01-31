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
            // Copy / paste error?
            // Assert.That(new CombiningStrings().GreetsByCombiningStringsWithFormats("Mickey"), Is.EqualTo("Hello, Mickey"));
            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithStringBuilder("Mickey"), Is.EqualTo("Hello, Mickey"));
        }
    }
}
