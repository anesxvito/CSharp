| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Field_GetDeclaration_ConstField
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            FieldInfo @this = typeof (FieldModel<int>).GetField("ConstField", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public const int ConstField = 1;", result);
        }
    }
}