namespace CountWords
{
    // This is a data structure
    // It's a data structure representing a word that occurred, and how many
    // times it occurred.
    public class WordCount
    {
        public string Word { get; set; }
        public int Count { get; set; }

        public WordCount(string word)
        {
            Word = word;
            Count = 1;
        }

        public WordCount(string word, int count)
        {
            Word = word;
            Count = count;
        }

        public override bool Equals(object obj)
        {
            var other = obj as WordCount;
            return (other != null) && (Word == other.Word) && (Count == other.Count);
        }
    }
}