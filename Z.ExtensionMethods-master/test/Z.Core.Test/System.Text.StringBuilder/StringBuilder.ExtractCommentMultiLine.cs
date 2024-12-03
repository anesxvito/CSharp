| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractCommentMultiLine
    {
        [TestMethod]
        public void ExtractCommentMultiLine()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractCommentMultiLine());
            Assert.AreEqual("/*z", new StringBuilder("/*z").ExtractCommentMultiLine().ToString());
            Assert.AreEqual("/*z", new StringBuilder("/*/*z").ExtractCommentMultiLine(2).ToString());
            Assert.AreEqual("/*z*/", new StringBuilder("/**//*z*/").ExtractCommentMultiLine(4, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);
        }
    }
}