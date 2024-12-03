| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_EqualsIgnoreCase
    {
        [TestMethod]
        public void EqualsIgnoreCase()
        {
            // Type
            string @this = "FizBuzz";

            // Examples
            bool value1 = @this.EqualsIgnoreCase("fizbuzz"); // return true;
            bool value2 = @this.EqualsIgnoreCase("FooBar"); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsFalse(value2);
        }
    }
}