using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.DataBase
{
    public class SqliteFactory(string connectionString) : IDbConnectionFactory
    {
        public IDbConnection CreateConnection()
            => new SqliteConnection(connectionString);
    }
}
