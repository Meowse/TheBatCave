﻿using System.Text;

namespace ExploringCSharp
{
    public class CombiningStrings
    {
        public string GreetsByCombiningStringsWithPlus(string name)
        {
            name = "Mickey";
            return "Hello, " + name;
        }

        public string GreetsByCombiningStringsWithFormats(string name)
        {
            // try googling "string formatting in C#"
            const string value1 = "Hello";
            const string value2 = "Mickey.";

            string result = string.Format("{0}, {1}",
                value1,
                value2);

            return result;
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            var builder = new StringBuilder(100);
            
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            return builder.ToString();
        }
    }
}
