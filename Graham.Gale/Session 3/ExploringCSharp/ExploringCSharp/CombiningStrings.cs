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
            //return null;
            string hello = "Hello, ";
            string stringoutput2 = string.Format("{0}{1}", hello, name);
            return stringoutput2;

        }

        public string GreetsByCombiningStringsWithStringBuilder(string name)
        {
            StringBuilder builder = new StringBuilder(100);
            // Try typing "builder." and seeing what auto-complete options ReSharper gives you.
            return builder.ToString();
            
        }
    }
}
