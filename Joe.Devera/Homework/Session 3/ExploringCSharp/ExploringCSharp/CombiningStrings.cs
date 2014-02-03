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
            return GreetsByCombiningStringsWithPlus("Mickey");
        }

        public StringBuilder GreetsByCombiningStringsWithStringBuilder(string name)
        {
            var builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            return builder;
            //builder.
            //ReSharper asks if i want to remove unreachable code or comment unreachable code 

        }
    }
}
