| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Net.Test
{
    [TestClass]
    public class System_Net_WebRequest_GetResponseSafe
    {
        [TestMethod]
        public void GetResponseSafe()
        {
            // Type
            WebRequest @this = WebRequest.Create("http://www.zzzportal.com/");

            // Examples
            WebResponse value = @this.GetResponseSafe(); // return a response;

            // Unit Test
            Assert.IsNotNull(value);
        }
    }
}