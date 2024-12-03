| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_DirectoryInfo_CopyTo
    {
        [TestMethod]
        public void CopyTo()
        {
            // Type
            var @this = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_CopyTo"));
            var copyTo = new DirectoryInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_CopyTo2"));

            Directory.CreateDirectory(@this.FullName);
            @this.CreateSubdirectory("FizzBuzz");
            var result1 = @this.GetDirectories().Length;

            // Exemples
            @this.CopyTo(copyTo.FullName);

            // Unit Test
            var result2 = copyTo.GetDirectories().Length;
            Assert.AreEqual(1, result1);
            Assert.AreEqual(1, result2);
        }
    }
}