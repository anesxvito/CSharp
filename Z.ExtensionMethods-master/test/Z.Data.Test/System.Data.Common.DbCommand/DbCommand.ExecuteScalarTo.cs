| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_Common_DbCommand_ExecuteScalarTo
    {
        [TestMethod]
        public void ExecuteScalarTo()
        {
            const string sql = @"SELECT 1 As IntColumn";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    var result = @this.ExecuteScalarTo<int>();

                    // UnitTest
                    Assert.AreEqual(1, result);
                }
            }
        }
    }
}