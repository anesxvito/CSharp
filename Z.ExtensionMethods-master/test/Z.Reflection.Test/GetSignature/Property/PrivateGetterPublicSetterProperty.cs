| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Property_GetSignature_PrivateGetterPublicSetterProperty
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            PropertyInfo @this = typeof(PropertyModel<int>).GetProperty("PrivateGetterPublicSetterProperty", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("PrivateGetterPublicSetterProperty", result);
        }
    }
}