| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractStringArobasSingleQuote
    {
        [TestMethod]
        public void ExtractStringArobasSingleQuote()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractStringArobasSingleQuote());
            Assert.AreEqual("z", new StringBuilder("@'z'").ExtractStringArobasSingleQuote().ToString());
            Assert.AreEqual("z", new StringBuilder("@@'z'z").ExtractStringArobasSingleQuote(1, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}