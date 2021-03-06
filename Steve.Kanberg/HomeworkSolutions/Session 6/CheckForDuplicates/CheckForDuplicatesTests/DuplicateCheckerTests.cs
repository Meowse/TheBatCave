﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
        public void CountNumberOfDuplicates()
        {
            var nbrOfDuplicates = new List<int> {1, 1, 2, 2, 2, 3, 4, 5};
            Assert.That(_duplicateChecker.CountDuplicates(nbrOfDuplicates), Is.EqualTo(5));
        }

        [Test]
        public void DistinctCountofDuplicatesTest()
        {
            var nbrofDistDups = new List<int> {1, 1, 2, 2, 2, 3, 4, 5};
            Assert.That(_duplicateChecker.DistinctCount(nbrofDistDups), Is.EqualTo(2));
        }

        [Test]
        public void GetDuplicatesCountTest()
        {
            var dupsToCount = new List<int> {1, 1, 2, 2, 2, 2, 3, 4, 5, 5};
            Dictionary<int, int> Dups1 = new Dictionary<int, int>();
            Dups1.Add(1, 2);
            Assert.That(_duplicateChecker.GetDuplicatesCount(dupsToCount), Is.EqualTo(Dups1));
            Dictionary<int, int> Dups2 = new Dictionary<int, int>();
            Dups1.Add(2, 4);
            Assert.That(_duplicateChecker.GetDuplicatesCount(dupsToCount), Is.EqualTo(Dups2));
            Dictionary<int, int> Dups3 = new Dictionary<int, int>();
            Dups1.Add(5, 2);
            Assert.That(_duplicateChecker.GetDuplicatesCount(dupsToCount), Is.EqualTo(Dups3));

        }
    }
}
