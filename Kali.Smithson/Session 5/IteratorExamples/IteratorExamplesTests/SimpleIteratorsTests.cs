using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IteratorExamples;
using NUnit.Framework;

namespace IteratorExamplesTests
{
    [TestFixture]
    public class SimpleIteratorsTests
    {
        private static readonly SimpleIterators SimpleIterators = new SimpleIterators();

        [Test]
        public void CanCountToTen()
        {
            int[] expected = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Assert.That(SimpleIterators.CountToTen(), Is.EqualTo(expected));
        }

        [Test]
        public void CanCountToNWithWhileLoop()
        {
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            Assert.That(SimpleIterators.CountToWithWhileLoop(7), Is.EqualTo(expected));

            int[] expected2 = {1, 2, 3, 4};
            Assert.That(SimpleIterators.CountToWithWhileLoop(4), Is.EqualTo(expected2));
        }

        [Test]
        public void CanCountToNWithForLoop()
        {
            int[] expected = { 1, 2, 3, 4, 5, 6, 7 };
            Assert.That(SimpleIterators.CountToWithForLoop(7), Is.EqualTo(expected));

            int[] expected2 = { 1, 2, 3, 4 };
            Assert.That(SimpleIterators.CountToWithForLoop(4), Is.EqualTo(expected2));
        }


        [Test]
        public void CanCountFromToWithWhileLoop()
        {
            int[] expected = { 3, 4, 5, 6, 7 };
            Assert.That(SimpleIterators.CountFromToWithWhileLoop(3, 7), Is.EqualTo(expected));

            int[] expected2 = { 2, 3, 4 };
            Assert.That(SimpleIterators.CountFromToWithWhileLoop(2, 4), Is.EqualTo(expected2));
        }

        [Test]
        public void CanCountFromToByWithForLoop()
        {
            int[] expected = { 3, 6 };
            Assert.That(SimpleIterators.CountFromToByWithForLoop(3, 7, 3), Is.EqualTo(expected));

            int[] expected2 = { 2, 3, 4 };
            Assert.That(SimpleIterators.CountFromToByWithForLoop(2, 4, 1), Is.EqualTo(expected2));

            int[] expected3 = { 4, 6, 8, 10, 12 };
            Assert.That(SimpleIterators.CountFromToByWithForLoop(4, 12, 2), Is.EqualTo(expected3));
        }

        [Test]
        public void CanCountFromToByWithWhileLoop()
        {
            int[] expected = { 3, 6 };
            Assert.That(SimpleIterators.CountFromToByWithWhileLoop(3, 7, 3), Is.EqualTo(expected));

            int[] expected2 = { 2, 3, 4 };
            Assert.That(SimpleIterators.CountFromToByWithWhileLoop(2, 4, 1), Is.EqualTo(expected2));

            int[] expected3 = { 4, 6, 8, 10, 12 };
            Assert.That(SimpleIterators.CountFromToByWithWhileLoop(4, 12, 2), Is.EqualTo(expected3));
        }

        [Test]
        public void CanCountFromToWithForLoop()
        {
            int[] expected = { 3, 4, 5, 6, 7 };
            Assert.That(SimpleIterators.CountFromToWithForLoop(3, 7), Is.EqualTo(expected));

            int[] expected2 = { 2, 3, 4 };
            Assert.That(SimpleIterators.CountFromToWithForLoop(2, 4), Is.EqualTo(expected2));
        }

        [Test]
        public void CanGetInterviewedByMickey()
        {
            int[] expected = { 100, 93, 86, 79, 72, 65, 58, 51, 44, 37, 30, 23, 16, 9, 2 };
            Assert.That(SimpleIterators.BackFromBy(), Is.EqualTo(expected));
        }

        [Test]
        public void CanReturnEveryOtherElement()
        {
            string[] input = {"I", "don't", "hate", "Microsoft", "C#"};
            string[] expected = {"I", "hate", "C#"};        
            Assert.That(SimpleIterators.EveryOtherElement(input), Is.EqualTo(expected));        
        }

        [Test]
        public void CanReturnEveryOtherElementFromEvenLengthList()
        {
            string[] input = { "I", "don't", "hate", "Microsoft", "C#", "...yet."};
            string[] expected = { "I", "hate", "C#" };
            Assert.That(SimpleIterators.EveryOtherElement(input), Is.EqualTo(expected));
        }

        [Test]
        public void CanReturnEveryOtherElementFromEmptyList()
        {
            string[] input = { };
            string[] expected = { };
            Assert.That(SimpleIterators.EveryOtherElement(input), Is.EqualTo(expected));
        }

        [Test]
        public void CanReturnEveryOtherElementFromListWithOneItem()
        {
            string[] input = { "I" };
            string[] expected = { "I" };
            Assert.That(SimpleIterators.EveryOtherElement(input), Is.EqualTo(expected));
        }


    }
}
