| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetSignature_InheritedClassAndInterface
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            Type @this = typeof(InheritedClassAndInterface);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("InheritedClassAndInterface", result);
        }
    }
}