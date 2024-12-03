| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_Substring
    {
        [TestMethod]
        public void Substring()
        {
            // Type
            var @this = new StringBuilder("0123456789");

            // Exemples
            var result1 = @this.Substring(4); // return "456789"
            var result2 = @this.Substring(4, 2); // return "45"

            // Unit Test
            Assert.AreEqual("456789", result1);
            Assert.AreEqual("45", result2);
        }
    }
}