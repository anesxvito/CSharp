| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetDeclaration_IPublicInterface
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            Type @this = typeof (IPublicInterface);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public interface IPublicInterface", result);
        }
    }
}