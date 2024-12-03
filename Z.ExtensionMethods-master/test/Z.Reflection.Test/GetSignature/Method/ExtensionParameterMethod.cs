| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Method_GetSignature_ExtensionParameterMethod
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            var @this = typeof(ExtensionMethodModel).GetMethod("ExtensionParameterMethod", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("ExtensionParameterMethod(int)", result);
        }
    }
}