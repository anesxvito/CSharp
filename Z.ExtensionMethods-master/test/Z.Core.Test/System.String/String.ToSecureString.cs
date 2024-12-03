| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_String_ToSecureString
    {
        [TestMethod]
        public void ToSecureString()
        {
            // Type
            string @this = "FizzBuzz";

            // Exemples
            SecureString result = @this.ToSecureString();
        }
    }
}