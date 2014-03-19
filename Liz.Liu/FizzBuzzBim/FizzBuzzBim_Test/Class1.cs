using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzBim;
using NUnit.Framework;

namespace FizzBuzzBim_Test
{
    public class Class1
    {
        [Test]
        public void FizzBuzzBim(int input, int input5, int input3, int input2, string result)
        {
            string expected = "FizzBuzzBim";
           Assert.That(Class1.FizzBuzzBim(25,5,3,2,"FizzBuzzBim"), Is.EqualTo(expected));


//            Assert.That(new CombiningStrings().GreetsByCombiningStringsWithStringBuilder("Mickey"), Is.EqualTo("Hello, Mickey"));



        }

       
    }
}
