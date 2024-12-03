| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_TimeSpan_UtcAgo
    {
        [TestMethod]
        public void UtcAgo()
        {
            // Type
            var @this = new TimeSpan(1, 0, 0, 0);

            // Examples
            DateTime value = @this.UtcAgo(); // return yesterday.

            // Unit Test
            Assert.IsTrue(DateTime.UtcNow.Subtract(value).Days >= 1);
        }
    }
}