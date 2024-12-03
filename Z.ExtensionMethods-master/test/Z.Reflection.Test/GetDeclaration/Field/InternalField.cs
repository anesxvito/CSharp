| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Field_GetDeclaration_InternalField
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            var @this = typeof(FieldModel<int>).GetField("InternalField", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("internal int InternalField;", result);
        }
    }
}