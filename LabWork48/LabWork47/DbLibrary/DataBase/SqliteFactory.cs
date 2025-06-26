using Microsoft.Data.Sqlite;
using System.Data;

namespace DbLibrary.DataBase
{
    public class SqliteFactory(string connectionString) : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
            => new SqliteConnection(connectionString);
    }
}
