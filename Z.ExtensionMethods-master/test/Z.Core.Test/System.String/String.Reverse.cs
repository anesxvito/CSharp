| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_Reverse
    {
        [TestMethod]
        public void Reverse()
        {
            // Type
            string @this = "FizzBuzz";

            // Examples
            string value = @this.Reverse(); // return "zzuBzziF";

            // Unit Test
            Assert.AreEqual("zzuBzziF", value);
        }
    }
}