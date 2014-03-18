using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    // "word1:count1;word2:count2;word3:count3;..."

    public class WordCounter
    {
        // "instance" variable: a different copy of this exists for each
        // instance of the class, and lasts as long as the instance exists
        //
        // We indicate this, by convention, with the initial underscore.
        private readonly string[] _words;

        public WordCounter(String corpus)
        {
            _words = corpus.Split(' ');
        }



        // for each word in "_words":
        //   1)check if it's in result already.
        //   2a) if it isn't, add it *** and set the count to 1 ***
        //   2b) if it is, increment the count.


        // For input "the the happy fox slept fox", this would return
        // [(the, 2), (happy, 1), (fox, 2), (slept, 1)]
        // Where the (word, count) pairs are WordCount objects.
        public List<WordCount> GetResultsAsListOfWordCounts()
        {
            var wordCounts = new List<WordCount>();

            foreach (string word in _words)
            {
                WordCount wordCounter = GetWordCountForWord(wordCounts, word);
                if (wordCounter != null)
                {
                    wordCounter.Count++;
                }
                else
                {
                    wordCounts.Add(new WordCount(word));
                }
            }

            return wordCounts;
        }

        // wordCounts.Add(new WordCount { Word = word, Count = 1 });


        //                    WordCount newWordCount; // Declares the newWordCount variable
        //                    newWordCount = new WordCount();  // Creates a new WordCount object                    
        //                    newWordCount.Count = 1; // Initialize its Count to 1
        //                    newWordCount.Word = word; // Initialize its Word to word
        //                    wordCounts.Add(newWordCount);





        // Go through each index card in the stack:
        //   if the word appears on the card, return true
        // Eight lines, instead of two lines, with for loop
        //            for (int i = 0; i < list.Count; i++)
        //            {
        //                if (list[i].word == word)
        //                {
        //                    return true;
        //                }
        //            }
        //            return false;
        // Simpler, but not shorter, with foreach
        //            foreach (WordCount wordCount in list)
        //            {
        //                if (wordCount.word == word)
        //                {
        //                    return true;
        //                }
        //            }
        //            return false;
        private bool HasWordCountForWord(List<WordCount> list, string word)
        {
            //return list.Any(wordCount => wordCount.word == word);
            return GetWordCountForWord(list, word) != null;
        }

        private WordCount GetWordCountForWord(List<WordCount> list, string word)
        {
            return list.Find(wordCount => wordCount.Word == word);
        }

        // For the same input, this would return
        // ([the, happy, fox, slept], [2, 1, 2, 1])
        // where the (list, list) pair is a WordCountRecord
        public WordCountRecord GetResultsAsWordCountRecord()
        {
            WordCountRecord wordCounter = new WordCountRecord();
            wordCounter.Words = new List<string>();
            wordCounter.Counts = new List<int>();
            const int count = 0;
            foreach (var word in _words)
            {
                if (!wordCounter.Words.Contains(word))
            }
            string word;
            wordCounter.Words.Add(word);
                wordCounter.Counts.Add(CountNumberOfSimilarWords(word, count));
                
                return wordCounter;
        }

        private int CountNumberOfSimilarWords(object word, int count)
        {
            throw new NotImplementedException();
        }


        // For each word in the sentence:
        //    check if it's in the dictionary (as a key)
        //    if it's in the dictionary, increment the count by 1
        //    else add it to the dictionary and initialize the count to 1
            

        // And for the same input, this would return
        // {{the, 2}, {happy, 1}, {fox, 2}, {slept, 1}}
        // where the entire thing is a dictionary from strings to
        // integers, and the {word, count} pairs are {key, value} 
        // entries in the dictionary.
        public Dictionary<string, int> GetResultsAsDictionary()
        {
            var counts = new Dictionary<string, int>();
            foreach (string word in _words)
            {
                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    // counts[word] = 1;
                    counts.Add(word, 1);
                }
            }
            return counts;
        } 
    }
}
