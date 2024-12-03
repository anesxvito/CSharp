| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractKeyword
    {
        [TestMethod]
        public void ExtractKeyword()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractKeyword());
            Assert.AreEqual(null, new StringBuilder("1.1").ExtractKeyword());
            Assert.AreEqual(null, new StringBuilder("@1a").ExtractKeyword());
            Assert.AreEqual("for", new StringBuilder("for foreach").ExtractKeyword().ToString());
            Assert.AreEqual("@for", new StringBuilder("zzz @for foreach").ExtractKeyword(4, out endIndex).ToString());
            Assert.AreEqual(7, endIndex);
        }
    }
}