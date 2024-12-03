| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractHexadecimal
    {
        [TestMethod]
        public void ExtractHexadecimal()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractHexadecimal());
            Assert.AreEqual("0x2A", new StringBuilder("0x2A").ExtractHexadecimal().ToString());
            Assert.AreEqual("0x2A", new StringBuilder("0x0x2A").ExtractHexadecimal(2).ToString());
            Assert.AreEqual("0x2FUL", new StringBuilder("0x0x2FUL").ExtractHexadecimal(2, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);
        }
    }
}