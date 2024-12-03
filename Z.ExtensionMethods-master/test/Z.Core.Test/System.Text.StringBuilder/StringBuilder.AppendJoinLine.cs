| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_AppendLineJoin
    {
        [TestMethod]
        public void AppendLineFormat()
        {
            var list = new List<string> {"Fizz", "Buzz"};

            // Type
            var @this = new StringBuilder();

            // Exemples
            @this.AppendLineJoin(",", list); // return "Fizz,Buzz" + Environment.NewLine;

            // Unit Test
            Assert.AreEqual("Fizz,Buzz" + Environment.NewLine, @this.ToString());
        }
    }
}