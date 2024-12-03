| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsNow
    {
        [TestMethod]
        public void IsNow()
        {
            // Type
            DateTime @this = DateTime.Now;

            // Examples
            bool value1 = @this.IsNow();

            // Unit Test
        }
    }
}