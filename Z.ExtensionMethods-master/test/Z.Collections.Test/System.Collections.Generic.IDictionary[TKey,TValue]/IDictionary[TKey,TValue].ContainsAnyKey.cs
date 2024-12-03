| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_IDictionary_TKey_TValue_ContainsAnyKey
    {
        [TestMethod]
        public void ContainsAnyKey()
        {
            // Type
            var @this = new Dictionary<string, string> {{"Fizz", "Buzz"}, {"Fizz2", "Buzz2"}};

            // Exemples
            bool value1 = @this.ContainsAnyKey("Fizz", "Fizz3"); // return true;
            bool value2 = @this.ContainsAnyKey("Fizz3", "Fizz4"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}