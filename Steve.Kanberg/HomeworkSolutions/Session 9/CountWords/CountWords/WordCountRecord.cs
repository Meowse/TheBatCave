using System.Collections.Generic;

namespace CountWords
{
    // This is a data structure representing the answer to the question.
    public class WordCountRecord
    {
        // This is a data structure representing which words occurred in the text
        public List<string> Words { get; set; }
        // This is a data structure representing how many times the positionally
        // corresponding word occurred in the text
        public List<int> Counts { get; set; }

        public List<int> CountRecord()
        {
            List<string> setWord = new List<string>();

            foreach (var word in setWord)
            {
                if (setWord.Contains(word))
                    setWord[word.ToString()]++;
                else
                    setWord[word.ToString()] = 1;
            }
            return setWord.;
        }
    }
}