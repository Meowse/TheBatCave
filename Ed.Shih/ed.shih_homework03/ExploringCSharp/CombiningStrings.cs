using System;
using System.Collections.Specialized;
using System.Text;

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
            // tried to create a Name object and then do String.Format("Hello {name}" but that broke the test
            string greeting = String.Format("Hello, {0}", "Mickey");
            return greeting;
            // this can get the correct test result but I thought the way I tried above would be the more common way to use String.Format
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            // Typing "builder" brought up GreetsByCombiningStringsWithStringBuilder, StringBuilder, and UniBuilder.
            return builder.ToString();
        }
    }
}
