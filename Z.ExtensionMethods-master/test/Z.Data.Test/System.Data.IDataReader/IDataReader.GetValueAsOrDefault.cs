| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Data.Test
{
    [TestClass]
    public class System_Data_IDataReader_GetValueAsOrDefault
    {
        [TestMethod]
        public void GetValueAsOrDefault()
        {
            const string sql = @"SELECT 1 As IntColumn";

            // Examples
            using (var conn = new SqlConnection(My.Config.ConnectionString.UnitTest.ConnectionString))
            {
                using (SqlCommand @this = conn.CreateCommand())
                {
                    conn.Open();
                    @this.CommandText = sql;
                    using (SqlDataReader reader = @this.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var result1 = reader.GetValueAs<int>("IntColumn");
                            var result2 = reader.GetValueAsOrDefault<int>("UnknownColumn");
                            int result3 = reader.GetValueAsOrDefault("UnknownColumn", -1);
                            int result4 = reader.GetValueAsOrDefault("UnknownColumn", (dataReader, s) => -2);

                            // UnitTest
                            Assert.AreEqual(1, result1);
                            Assert.AreEqual(0, result2);
                            Assert.AreEqual(-1, result3);
                            Assert.AreEqual(-2, result4);
                        }
                    }
                }
            }
        }
    }
}