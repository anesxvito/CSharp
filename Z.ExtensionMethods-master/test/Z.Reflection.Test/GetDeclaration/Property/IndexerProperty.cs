| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Linq;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Property_GetDeclaration_IndexerProperty
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            PropertyInfo @this = typeof (PropertyModel<int>).GetProperties().First(x => x.Name == "Item" && x.GetIndexParameters().Length == 3);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public int this[int param1, int param2, int param3] { get; set; }", result);
        }
    }
}