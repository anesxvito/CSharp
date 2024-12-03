| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_EncryptRSA
    {
        [TestMethod]
        public void EncryptRSA()
        {
            // Type
            string @this = "Fizz";

            // Examples
            string value = @this.EncryptRSA("Buzz"); // return Encrypted string;

            // Unit Test
            Assert.AreEqual("Fizz", value.DecryptRSA("Buzz"));
        }
    }
}