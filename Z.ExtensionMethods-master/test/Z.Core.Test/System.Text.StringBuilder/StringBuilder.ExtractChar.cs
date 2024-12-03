| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractChar
    {
        [TestMethod]
        public void ExtractChar()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual('a', new StringBuilder("'a'").ExtractChar());
            Assert.AreEqual('\'', new StringBuilder("'\''").ExtractChar());
            Assert.AreEqual('\'', new StringBuilder("z'\''").ExtractChar(1, out endIndex));
            Assert.AreEqual(3, endIndex);

            try
            {
                new StringBuilder("'").ExtractChar();
                throw new Exception("invalid!");
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Invalid char at position: 0", ex.Message);
            }
        }
    }
}