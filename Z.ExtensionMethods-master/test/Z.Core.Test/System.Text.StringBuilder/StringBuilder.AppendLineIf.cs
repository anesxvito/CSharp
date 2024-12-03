| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendLineIf
    {
        [TestMethod]
        public void AppendLineIf()
        {
            // Type
            var @this = new StringBuilder();

            // Exemples
            @this.AppendLineIf(x => x.Contains("F"), "Fizz", "Buzz"); // return "FizzBuzz";

            // Unit Test
            Assert.AreEqual("Fizz" + Environment.NewLine, @this.ToString());
        }
    }
}