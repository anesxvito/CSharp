| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Field_GetDeclaration_ProtectedInternalField
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            var @this = typeof(FieldModel<int>).GetField("ProtectedInternalField", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("protected internal int ProtectedInternalField;", result);
        }
    }
}