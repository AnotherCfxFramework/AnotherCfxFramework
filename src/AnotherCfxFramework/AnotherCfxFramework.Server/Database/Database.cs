
using System.Data;
using System.Data.SqlClient;

namespace AnotherCfxFramework.Server.Database
{
    public static class Database
    {

        public static IDbConnection connection { get; } = new SqlConnection("");


    }
}
