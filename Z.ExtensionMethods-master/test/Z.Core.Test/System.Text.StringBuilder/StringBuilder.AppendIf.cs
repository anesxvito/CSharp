| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendIf
    {
        [TestMethod]
        public void AppendIf()
        {
            // Type
            var @this = new StringBuilder();

            // Exemples
            @this.AppendIf(x => x.Contains("F"), "Fizz", "Buzz"); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("Fizz", @this.ToString());
        }
    }
}