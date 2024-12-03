| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_FormatWith
    {
        [TestMethod]
        public void FormatWith()
        {
            // Type
            string @this = "{0}{1}";

            // Examples
            string value = @this.FormatWith("Fizz", "Buzz"); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", value);
        }
    }
}