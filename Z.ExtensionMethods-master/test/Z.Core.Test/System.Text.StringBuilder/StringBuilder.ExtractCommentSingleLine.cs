| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractCommentSingleLine
    {
        [TestMethod]
        public void ExtractCommentSingleLine()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractCommentSingleLine());
            Assert.AreEqual("//z", new StringBuilder("//z").ExtractCommentSingleLine().ToString());
            Assert.AreEqual("//z", new StringBuilder("////z").ExtractCommentSingleLine(2).ToString());
            Assert.AreEqual("//z", new StringBuilder("////z" + Environment.NewLine + "z").ExtractCommentSingleLine(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}