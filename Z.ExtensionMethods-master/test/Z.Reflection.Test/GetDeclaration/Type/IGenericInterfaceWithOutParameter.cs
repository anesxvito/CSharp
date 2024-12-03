| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetDeclaration_IGenericInterfaceWithOutParameter
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            Type @this = typeof (IGenericInterfaceWithOutParameter<>);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public interface IGenericInterfaceWithOutParameter<out T>", result);
        }
    }
}