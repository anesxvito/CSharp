| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Environement_SpecialFolder_GetFolderPath
    {
        [TestMethod]
        public void ToMoney()
        {
            // Type
            const Environment.SpecialFolder specialFolder = Environment.SpecialFolder.Desktop;

            // Exemples
            string path = specialFolder.GetFolderPath();

            // Unit Test
            Assert.AreEqual(Environment.GetFolderPath(specialFolder), path);
        }
    }
}