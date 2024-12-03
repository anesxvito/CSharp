﻿| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_IsPalindrome
    {
        [TestMethod]
        public void IsPalindrome()
        {

            // Examples
            bool value1 = "abba".IsPalindrome();  // return true;
            bool value2 = "ab ba".IsPalindrome();  // return true;
            bool value3 = "ab'ba".IsPalindrome();   // return true;
            bool value4 = "abca".IsPalindrome();      // return false;
            bool value5 = "ab b ab".IsPalindrome(); // return false;

            // Unit Test
            Assert.IsTrue(value1);
            Assert.IsTrue(value2);
            Assert.IsTrue(value3);
            Assert.IsFalse(value4);
            Assert.IsFalse(value5);
        }
    }
}
