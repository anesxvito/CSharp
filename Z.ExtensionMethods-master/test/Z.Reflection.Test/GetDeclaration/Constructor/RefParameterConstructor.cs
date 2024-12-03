| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Constructor_GetDeclaration_RefParameterConstructor
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            ConstructorInfo @this = typeof(RefParameterConstructorModel).GetConstructors()[0];

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public RefParameterConstructorModel(ref int i)", result);
        }
    }
}