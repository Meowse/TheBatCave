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
    }
}
