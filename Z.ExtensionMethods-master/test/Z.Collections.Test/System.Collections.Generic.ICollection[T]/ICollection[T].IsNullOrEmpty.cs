| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Collections.Test
{
    [TestClass]
    public class System_Collections_Generic_ICollection_T_IsNullOrEmpty
    {
        [TestMethod]
        public void IsNullOrEmpty()
        {
            // Type
            var @this = new List<string>();

            // Examples
            bool value1 = @this.IsNullOrEmpty(); // return true;

            @this.Add("Fizz");
            bool value2 = @this.IsNullOrEmpty(); // return false;

            @this = null;
            bool value3 = @this.IsNullOrEmpty(); // return true;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
            Assert.IsTrue(value3);
        }
    }
}