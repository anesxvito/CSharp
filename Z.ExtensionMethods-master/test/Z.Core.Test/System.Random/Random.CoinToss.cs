| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_Random_CoinToss
    {
        [TestMethod]
        public void CoinToss()
        {
            // Type
            var @this = new Random();

            // Examples
            bool value = @this.CoinToss(); // return true or false at random.
        }
    }
}