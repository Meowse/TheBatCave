using System.Collections.Generic;
using CountWords;
using NUnit.Framework;

namespace CountWordsTests
{
    [TestFixture]
    public class WordCounterTests
    {
        [Test]
        public void TestCountsWordsAsListsOfWordCount()
        {
            var counter = new WordCounter("the slower the fox ran the quicker the fox ran tired");
            var expectedCounts = new List<WordCount>
            {
                new WordCount("the", 4),
                new WordCount("slower", 1),
                new WordCount("fox", 2),
                new WordCount("ran", 2),
                new WordCount("quicker", 1),
                new WordCount("tired", 1)
            };
            List<WordCount> actualCounts = counter.GetResultsAsListOfWordCounts();
            Assert.That(actualCounts, Is.EqualTo(expectedCounts));
        }

        [Test]
        public void TestCountsWordsAsWordCountRecord()
        {
            var counter = new WordCounter("the slower the fox ran the quicker the fox ran tired");
            var expectedWords = new List<string> { "the", "slower", "fox", "ran", "quicker", "tired" };
            var expectedCounts = new List<int> { 4, 1, 2, 2, 1, 1 };
            WordCountRecord actualCounts = counter.GetResultsAsWordCountRecord();
            Assert.That(actualCounts.Words, Is.EqualTo(expectedWords));
            Assert.That(actualCounts.Counts, Is.EqualTo(expectedCounts));
        }

        [Test]
        public void TestCountsWordsAsDictionary()
        {
            var counter = new WordCounter("the slower the fox ran the quicker the fox ran tired");
            var expectedCounts = new Dictionary<string, int>
            {
                {"the", 4},
                {"slower", 1},
                {"fox", 2},
                {"ran", 2},
                {"quicker", 1},
                {"tired", 1}
            };

            Dictionary<string, int> actualCounts = counter.GetResultsAsDictionary();
            Assert.That(actualCounts, Is.EqualTo(expectedCounts));
        }
    }
}
