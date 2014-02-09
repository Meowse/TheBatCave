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
            var val1 = "Hello,";
            var val2 = name;
            return string.Format("{0} {1}", val1, val2);
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);
            builder.Append("Hello," + name);
            //builder.Append(name);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            return builder.ToString();
        }
    }
}
