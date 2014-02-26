using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    //public string FizzBuzz(int from, int to)
    //    {
    //        for (int i = from; i <= to; i++)
    //        {
    //            if (i%3 == 0 && i%5 == 0)
    //                return "FIZZBUZZ\n";
    //            if (i%3 == 0)
    //                return "FIZZ\n";
    //            if (i%5 == 0)
    //               return "BUZZ\n";
    //            else
    //               return i.toString();
    //        }
    //        return null;
    //    }

//[Test]
//        public void FizzBuzz()
//        {
//            const string expected = "FIZZ\n BUZZ\n FIZZ\n FIZZ\n BUZZ\n FIZZ\n FIZZBUZZ\n";
//            Assert.That(SimpleIterators.FizzBuzz(1, 15), Is.EqualTo(expected));
//        }
}
