| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToPlural
    {
        [TestMethod]
        public void ToPlural()
        {
            // Type
            string @this = "mouse";

            // Exemples
            string result = @this.ToPlural(); // return "mice";

            // Unit Test
            Assert.AreEqual("mice", result);
        }
    }
}