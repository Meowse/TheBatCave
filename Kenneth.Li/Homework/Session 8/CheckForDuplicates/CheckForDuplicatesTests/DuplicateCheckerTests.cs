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
        public void CountForDuplicatesTest()
        {
            var countDuplicates = new List<int>{1, 1, 2, 2, 2, 3, 4, 5};
            Assert.That(_duplicateChecker.CountDuplicates(countDuplicates), Is.EqualTo(5));
        }

        [Test]
        public void ReturnDistinctCountOfDuplicatesTests()
        {
            var input = new List<int> {1, 1, 2, 2, 2, 3, 4, 5};
            Assert.That(_duplicateChecker.ReturnDistinctCountOfDuplicates(input), Is.EqualTo(2));
        }

        [Test]
        public void ReturnDistinctCountOfDuplicatesForEmptyList()
        {
            var input = new List<int>();
            Assert.That(_duplicateChecker.ReturnDistinctCountOfDuplicates(input), Is.EqualTo(0));
        }

        [Test]
        public void ReturnDistinctCountOfDuplicatesForNoDuplicates()
        {
            var input = new List<int> { 1, 2, 3, 4, 5 };
            Assert.That(_duplicateChecker.ReturnDistinctCountOfDuplicates(input), Is.EqualTo(0));
        }

        [Test]
        public void ReturnDistinctCountOfDuplicatesForAllDuplicates()
        {
            var input = new List<int> { 1, 1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 5 };
            Assert.That(_duplicateChecker.ReturnDistinctCountOfDuplicates(input), Is.EqualTo(5));
        }

        [Test]
        public void ReturnDistinctCountOfDuplicatesForOutOfOrderDuplicates()
        {
            var input = new List<int> { 1, 2, 3, 2, 2, 2, 3, 3, 4, 5, 4 };
            Assert.That(_duplicateChecker.ReturnDistinctCountOfDuplicates(input), Is.EqualTo(3));
        }




        [Test]
        public void GetDuplicateCountsTest()
        {
            var input = new List<int> { 1, 1, 2, 2, 2, 3, 4, 5 };

            // Resharper will turn this into the dictionary initializer format below.
            //            var expectedResult = new Dictionary<int, int>();
            //            expectedResult.Add(1, 2); // 1 occurs 2 times
            //            expectedResult.Add(2, 3); // 2 occurs 3 times

            var expectedResult = new Dictionary<int, int> { { 1, 2 }, { 2, 3 } };
            Assert.That(_duplicateChecker.GetDuplicateCounts(input), Is.EqualTo(expectedResult));
        }

    }
}
