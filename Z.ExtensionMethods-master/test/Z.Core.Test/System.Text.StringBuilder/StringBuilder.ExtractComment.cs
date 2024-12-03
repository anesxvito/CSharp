| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractComment
    {
        [TestMethod]
        public void ExtractComment()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractComment());
            Assert.AreEqual("/*z", new StringBuilder("/*z").ExtractComment().ToString());
            Assert.AreEqual("/*z", new StringBuilder("/*/*z").ExtractComment(2).ToString());
            Assert.AreEqual("/*z*/", new StringBuilder("/**//*z*/").ExtractComment(4, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractComment());
            Assert.AreEqual("//z", new StringBuilder("//z").ExtractComment().ToString());
            Assert.AreEqual("//z", new StringBuilder("////z").ExtractComment(2).ToString());
            Assert.AreEqual("//z", new StringBuilder("////z" + Environment.NewLine + "z").ExtractComment(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}