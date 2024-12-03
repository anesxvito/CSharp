| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_HasExtension
    {
        [TestMethod]
        public void HasExtension()
        {
            // Type
            var file1 = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_GetDirectoryName", "CreateDirectory.txt"));
            var file2 = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_GetDirectoryName", "CreateDirectory"));

            // Examples
            bool result1 = file1.HasExtension(); // return true;
            bool result2 = file2.HasExtension(); // return false;

            // Unit Test
            Assert.IsTrue(result1);
            Assert.IsFalse(result2);
        }
    }
}