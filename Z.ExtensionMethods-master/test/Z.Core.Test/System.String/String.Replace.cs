| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Replace
    {
        [TestMethod]
        public void ReplaceByEmpty()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            string value = @this.Replace(2, 3, "123456"); // return "Fi123456uzz";

            // Unit Test
            Assert.AreEqual("Fi123456uzz", value);
        }
    }
}