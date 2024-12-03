| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Constructor_GetSignature_ParamsParameterConstructor
    {
        [TestMethod]
        public void GetSignature()
        {
            // Type
            ConstructorInfo @this = typeof(ParamsParameterConstructorModel).GetConstructors()[0];

            // Exemples
            string result = @this.GetSignature();

            // Unit Test
            Assert.AreEqual("ParamsParameterConstructorModel(int[])", result);
        }
    }
}