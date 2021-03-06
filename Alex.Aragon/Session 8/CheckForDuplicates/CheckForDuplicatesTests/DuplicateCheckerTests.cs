﻿using System;
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
        public void FiveDuplicatesList()
        {
            var fiveDuplicates = new HashSet<int> { 1, 1, 2, 2, 2, 3, 4, 5 };
            Assert.That(_duplicateChecker.CountDuplicates(fiveDuplicates), Is.EqualTo(5));
        }
        [Test]
        public void DistinctDuplicatesList()
        {
            var twoDuplicates = new List<int> { 1, 1, 2, 2, 2, 3, 4, 5 };
            Assert.That(_duplicateChecker.ReturnDistinctCountOfDuplicates(twoDuplicates), Is.EqualTo(2));
        }
        [Test]
        public void DictionaryList()
        {
            var input = new List<int> { 1, 1, 2, 2, 2, 3, 4, 5 };
            var result = new Dictionary<int, int> { { 1, 2 }, { 2, 3 }, {3, 1}, {4, 1}, {5, 1} };;
            Assert.That(_duplicateChecker.GetDuplicateCounts(input), Is.EqualTo(result));
        }
    }
}
