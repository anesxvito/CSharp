| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Reflection.Test
{
    [TestClass]
    public class Type_GetDeclaration_GenericClassWithWhereClause
    {
        [TestMethod]
        public void GetDeclaraction()
        {
            // Type
            Type @this = typeof (GenericClassWithWhereClause<>);

            // Exemples
            string result = @this.GetDeclaraction();

            // Unit Test
            Assert.AreEqual("public class GenericClassWithWhereClause<T> where T : class, new()", result);
        }
    }
}