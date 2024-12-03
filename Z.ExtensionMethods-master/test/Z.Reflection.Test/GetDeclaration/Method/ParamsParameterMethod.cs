| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Method_GetDeclaration_ParamsParameterMethod
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            var @this = typeof(MethodModel<>).GetMethod("ParamsParameterMethod", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public int ParamsParameterMethod(params int[] i)", result);
        }
    }
}