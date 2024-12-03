| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractStringDoubleQuote
    {
        [TestMethod]
        public void ExtractStringDoubleQuote()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractStringDoubleQuote());
            Assert.AreEqual("z", new StringBuilder("\"z\"").ExtractStringDoubleQuote().ToString());
            Assert.AreEqual("z", new StringBuilder("-\"z\"z").ExtractStringDoubleQuote(1, out endIndex).ToString());
            Assert.AreEqual(4, endIndex);
        }
    }
}