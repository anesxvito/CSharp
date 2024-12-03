| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToXmlDocument
    {
        [TestMethod]
        public void ToXmlDocument()
        {
            // Type
            string @this = "<Fizz>Buzz</Fizz>";

            // Examples
            XmlDocument value = @this.ToXmlDocument(); // return a XmlDocument from the specified string.

            // Unit Test
            Assert.AreEqual("<Fizz>Buzz</Fizz>", value.OuterXml);
        }
    }
}