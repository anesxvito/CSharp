| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractTriviaToken
    {
        [TestMethod]
        public void ExtractTriviaToken()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual("/*z", new StringBuilder("/*z").ExtractTriviaToken().ToString());
            Assert.AreEqual("/*z", new StringBuilder("/*/*z").ExtractTriviaToken(2).ToString());
            Assert.AreEqual("/*z*/", new StringBuilder("/**//*z*/").ExtractTriviaToken(4, out endIndex).ToString());
            Assert.AreEqual(8, endIndex);

            // Unit Test
            Assert.AreEqual("//z", new StringBuilder("//z").ExtractTriviaToken().ToString());
            Assert.AreEqual("//z", new StringBuilder("////z").ExtractTriviaToken(2).ToString());
            Assert.AreEqual("//z", new StringBuilder("////z" + Environment.NewLine + "z").ExtractTriviaToken(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);

            // UnitTest
            Assert.AreEqual("  ", new StringBuilder("   z").ExtractTriviaToken(1, out endIndex).ToString());
            Assert.AreEqual(2, endIndex);
        }
    }
}