using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckForDuplicates;
using NUnit.Framework;

namespace CheckForDuplicatesTests
{
    [TestFixture]
    public class DuplicateCheckerTests
    {
        private readonly DuplicateChecker _duplicateChecker = new DuplicateChecker();

        [Test]
        public void CanDetectDuplicates()
        {
//            var someDuplicates = new List<int> ( 1, 2, 3, 4, 5, 1 );
//            var someDuplicates = new List<int> ({ 1, 2, 3, 4, 5, 1 });
            var someDuplicates = new List<int> { 1, 2, 3, 4, 5, 3 };
            Assert.That(_duplicateChecker.HasDuplicates(someDuplicates), Is.True);
        }

        [Test]
        public void CanDetectNoDuplicates()
        {
            var noDuplicates = new List<int> { 1, 2, 3, 4, 5, 6 };
            Assert.That(_duplicateChecker.HasDuplicates(noDuplicates), Is.False);
        }

        [Test]
        public void ValidateDuplicatesNo()
        {
            var myList = new List<int> { 1, 1, 2, 2, 2, 3, 4, 5, 5, 6, 6 };
            Assert.That(_duplicateChecker.GetDuplicatesCount(myList), Is.EqualTo(9));
        }

        [Test]
        public void ValidateDistinctDuplicatesNo()
        {
            var myList = new List<int> {1, 1, 2, 2, 2, 3, 4, 5, 5,6,6};
            Assert.That(_duplicateChecker.GetDistinctDuplicatesCount(myList),Is.EqualTo(5));
        }

        [Test]
        public void ValidateDictionaryDuplicatesNo()
        {
            var myList = new List<int> { 1, 1, 2, 2, 2, 3, 4, 5, 5, 6, 6 };
            var num1 = _duplicateChecker.GetDictionaryDuplicatesCount(myList).ElementAt(0);

            Assert.That(num1.Value, Is.EqualTo(2));

            var num2 = _duplicateChecker.GetDictionaryDuplicatesCount(myList).ElementAt(1);

            Assert.That(num2.Value, Is.EqualTo(3));
        }
    }
}
