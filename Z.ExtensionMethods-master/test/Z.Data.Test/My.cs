| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Configuration;

namespace Z.Data.Test
{
    public static class My
    {
        public static class Config
        {
            public static class ConnectionString
            {
                public static ConnectionStringSettings UnitTest = ConfigurationManager.ConnectionStrings["UnitTest"];
            }
        }
    }
}