| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IfEmpty
    {
        [TestMethod]
        public void IfEmpty()
        {
            // Type
            string @this = "";

            // Exemples
            string result = @this.IfEmpty("FizzBuzz"); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("FizzBuzz", result);
        }
    }
}