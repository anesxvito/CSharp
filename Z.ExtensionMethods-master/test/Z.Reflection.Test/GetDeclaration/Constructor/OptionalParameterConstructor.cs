| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Constructor_GetDeclaration_OptionalParameterConstructor
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            ConstructorInfo @this = typeof(OptionalParameterConstructorModel).GetConstructors()[0];

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public OptionalParameterConstructorModel(int i = 0)", result);
        }
    }
}