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
            return string.Format("{1}, {0}", name, "Hello");
        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
//            StringBuilder builder = new StringBuilder("Hello, ", 100);
//            builder.Append(name);
            StringBuilder builder = new StringBuilder(100);
            builder.AppendFormat("Hello, {0}", name);
            return builder.ToString();
        }
    }
}
