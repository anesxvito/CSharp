| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetSignature_GenericClass
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            Type @this = typeof(GenericClass<,>);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("GenericClass<T1, T2>", result);
        }
    }
}