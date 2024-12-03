| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Property_GetSignature_IndexerProperty
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            PropertyInfo @this = typeof (PropertyModel<int>).GetProperties().First(x => x.Name == "Item" && x.GetIndexParameters().Length == 3);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("Item[int, int, int]", result);
        }
    }
}