| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Compression.Test
{
    [TestClass]
    public class System_String_CompressGZip
    {
        [TestMethod]
        public void CompressGZip()
        {
            // Type
            string @this = "FizzBuzz";

            // Exemples
            byte[] result = @this.CompressGZip();

            // Unit Test
            Assert.AreEqual("FizzBuzz", result.DecompressGZip());
        }
    }
}