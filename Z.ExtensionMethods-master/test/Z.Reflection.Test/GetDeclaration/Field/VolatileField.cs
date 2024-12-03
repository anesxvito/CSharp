| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Field_GetDeclaration_VolatileField
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            var @this = typeof(FieldModel<int>).GetField("VolatileField", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public volatile int VolatileField;", result);
        }
    }
}