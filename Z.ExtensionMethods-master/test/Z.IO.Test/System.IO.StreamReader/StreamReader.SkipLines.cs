| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.IO.Test
{
    [TestClass]
    public class System_IO_StreamReader_SkipLines
    {
        [TestMethod]
        public void SkipLines()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Examples_System_IO_FileInfo_SkipLines.txt");

            File.WriteAllLines(filePath, new[]
            {
                "Line1",
                "Line2",
                "Line3",
                "Line4"
            });

            using (var file = File.OpenText(filePath))
            {
                file.SkipLines(2);
                var nextLine = file.ReadLine();

                // Unit Test
                Assert.AreEqual("Line3", nextLine);
            }
        }
    }
}