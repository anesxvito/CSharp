| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_PathCombine
    {
        [TestMethod]
        public void PathCombine()
        {
            // Type
            var @this = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);

            string path1 = "Fizz";
            string path2 = "Buzz";

            // Exemples
            string result = @this.PathCombine(path1, path2); // Combine path1 and path2 with the DirectoryInfo

            // Unit Test
            Assert.AreEqual(Path.Combine(@this.FullName, path1, path2), result);
        }
    }
}