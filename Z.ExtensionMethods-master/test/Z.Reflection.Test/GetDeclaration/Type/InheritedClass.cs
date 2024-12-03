| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetDeclaration_InheritedClass
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            Type @this = typeof(InheritedClass);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public class InheritedClass : PublicClass", result);
        }
    }
}