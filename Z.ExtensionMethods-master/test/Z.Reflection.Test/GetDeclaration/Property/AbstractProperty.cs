| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Property_GetDeclaration_AbstractProperty
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            PropertyInfo @this = typeof(AbstractPropertyModel).GetProperty("AbstractProperty", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public abstract int AbstractProperty { get; set; }", result);
        }
    }
}