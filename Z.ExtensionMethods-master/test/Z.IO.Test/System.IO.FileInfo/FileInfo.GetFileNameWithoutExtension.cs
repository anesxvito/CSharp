| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_FileInfo_GetFileNameWithoutExtension
    {
        [TestMethod]
        public void GetFileNameWithoutExtension()
        {
            // Type
            var @this = new FileInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DirectoryInfo_GetDirectoryName", "CreateDirectory.txt"));

            // Examples
            string result = @this.GetFileNameWithoutExtension(); // return "CreateDirectory";

            // Unit Test
            Assert.AreEqual("CreateDirectory", result);
        }
    }
}