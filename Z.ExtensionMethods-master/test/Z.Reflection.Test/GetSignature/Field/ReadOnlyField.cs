| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Field_GetSignature_ReadOnlyField
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            var @this = typeof(FieldModel<int>).GetField("ReadOnlyField", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("ReadOnlyField", result);
        }
    }
}