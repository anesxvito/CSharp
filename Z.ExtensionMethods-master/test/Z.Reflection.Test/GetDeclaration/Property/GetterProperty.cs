| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Property_GetDeclaration_GetterProperty
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            PropertyInfo @this = typeof(PropertyModel<int>).GetProperty("GetterProperty", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public int GetterProperty { get; }", result);
        }
    }
}