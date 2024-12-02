// Description: C# Extension Methods | Enhance the .NET Framework and .NET Core with over 1000 extension methods.
// Website & Documentation: https://csharp-extension.com/
// Issues: https://github.com/zzzprojects/Z.ExtensionMethods/issues
// License (MIT): https://github.com/zzzprojects/Z.ExtensionMethods/blob/master/LICENSE
// More projects: https://zzzprojects.com/
// Copyright � ZZZ Projects Inc. All rights reserved.
using System;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Text_StringBuilder_ExtractCommentSingleLine
    {
        [TestMethod]
        public void ExtractCommentSingleLine()
        {
            int endIndex;

            // Unit Test
            Assert.AreEqual(null, new StringBuilder(" ").ExtractCommentSingleLine());
            Assert.AreEqual("//z", new StringBuilder("//z").ExtractCommentSingleLine().ToString());
            Assert.AreEqual("//z", new StringBuilder("////z").ExtractCommentSingleLine(2).ToString());
            Assert.AreEqual("//z", new StringBuilder("////z" + Environment.NewLine + "z").ExtractCommentSingleLine(2, out endIndex).ToString());
            Assert.AreEqual(5, endIndex);
        }
    }
}