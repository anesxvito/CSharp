| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Guid_IsNotEmpty
    {
        [TestMethod]
        public void IsNotEmpty()
        {
            // Type
            Guid guidEmpty = Guid.Empty;
            Guid guidValue = Guid.NewGuid();

            // Unit Test
            Assert.IsFalse(guidEmpty.IsNotEmpty());
            Assert.IsTrue(guidValue.IsNotEmpty());
        }
    }
}