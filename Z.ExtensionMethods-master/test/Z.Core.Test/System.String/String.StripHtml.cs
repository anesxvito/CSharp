| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_StripHtml
    {
        [TestMethod]
        public void StripHtml()
        {
            // Exemples
            string result1 = "FizzBuzz".StripHtml(); // return "FizzBuzz";
            string result2 = "Fizz<span>Buzz</span>".StripHtml(); // return "FizzBuzz";
            string result3 = "Fizz<span id='toto>' onclick=\"<test></test>\" escapeSingleQuote='\\\'>' escapeDoubleQuote=\"\\\">\">Buzz</span>".StripHtml(); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzBuzz", result2);
            Assert.AreEqual("FizzBuzz", result3);
        }
    }
}