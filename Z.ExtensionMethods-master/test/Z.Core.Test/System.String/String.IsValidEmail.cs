| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsValidEmail
    {
        [TestMethod]
        public void IsValidEmail()
        {
            {
                // Type
                string @this = "test@hotmail.com";

                // Exemples
                var result = @this.IsValidEmail(); // return true;

                // Unit Test
                Assert.IsTrue(result);
            }

            {
                // Type
                string @this = "mike@GOTBLOG.ONLINE";

                // Exemples
                var result = @this.IsValidEmail(); // return true;

                // Unit Test
                Assert.IsTrue(result);
            }
        }
    }
}