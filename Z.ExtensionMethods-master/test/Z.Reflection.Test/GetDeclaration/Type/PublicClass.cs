| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetDeclaration_PublicClass
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            Type @this = typeof (PublicClass);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public class PublicClass", result);
        }
    }
}