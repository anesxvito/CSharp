| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Array_ClearAll
    {
        [TestMethod]
        public void ClearAll()
        {
            // Type
            Array @this = new[] {"Fizz", "Buzz"};

            // Exemples
            @this.ClearAll(); // Remove all entries.

            // Unit Test
            Assert.AreEqual(null, @this.GetValue(0));
            Assert.AreEqual(null, @this.GetValue(1));
        }
    }
}