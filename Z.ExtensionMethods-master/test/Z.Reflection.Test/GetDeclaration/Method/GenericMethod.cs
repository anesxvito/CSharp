| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Method_GetDeclaration_GenericMethod
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            var @this = typeof(MethodModel<>).GetMethod("GenericMethod", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public T1 GenericMethod<T1, T2>(T1 i, T2 i2)", result);
        }
    }
}