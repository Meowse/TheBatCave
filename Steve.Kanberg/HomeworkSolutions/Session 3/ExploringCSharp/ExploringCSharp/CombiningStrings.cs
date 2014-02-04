﻿using System.Text;

namespace ExploringCSharp
{
    public class CombiningStrings
    {
        public string GreetsByCombiningStringsWithPlus(string name)
        {
            return "Hello, " + name;
        }

        public string GreetsByCombiningStringsWithFormats(string name)
        {
            // try googling "string formatting in C#"
            return string.Format("Hello, " + name);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);

            builder.Insert(0, 4);

            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            return builder.ToString();
        }
    }
}