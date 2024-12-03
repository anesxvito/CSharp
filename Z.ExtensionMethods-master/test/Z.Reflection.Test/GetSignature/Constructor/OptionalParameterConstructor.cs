| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Constructor_GetSignature_OptionalParameterConstructor
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            ConstructorInfo @this = typeof(OptionalParameterConstructorModel).GetConstructors()[0];

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("OptionalParameterConstructorModel(int)", result);
        }
    }
}