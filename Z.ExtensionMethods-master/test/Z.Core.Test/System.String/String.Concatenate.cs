| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_Concatenate
    {
        [TestMethod]
        public void Concatenate()
        {
            var list = new List<string> {"Fizz", "Buzz"};

            // Exemples
            var result1 = list.Concatenate();
            var result2 = list.Concatenate(x => x + x);

            // Unit Test
            Assert.AreEqual("FizzBuzz", result1);
            Assert.AreEqual("FizzFizzBuzzBuzz", result2);
        }
    }
}