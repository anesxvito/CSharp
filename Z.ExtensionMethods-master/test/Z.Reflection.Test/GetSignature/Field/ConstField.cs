| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Field_GetSignature_ConstField
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            FieldInfo @this = typeof (FieldModel<int>).GetField("ConstField", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("ConstField", result);
        }
    }
}