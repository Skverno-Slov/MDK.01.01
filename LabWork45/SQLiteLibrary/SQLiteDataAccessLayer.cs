using Microsoft.Data.Sqlite;
using System.Xml.Linq;

namespace SQLiteLibrary
{
    public static class SQLiteDataAccessLayer
    {
        public static string FileName { get; set; } =
            "Data Source = db2.sqlite";

        public static string ConnectionString ConnectionStringBuilder => new()
        {
            DataSource = "mssql"
        };
    };
//    public static string ConnectionString
//    {
//        get
//        {
//            SqlConnectionStringBuilder builder = new()
//            {
//                DataSource = ServerName,
//                InitialCatalog = DBName,
//                UserID = Login,
//                Password = Password,
//            };
//            return builder.ConnectionString;
//        }
//    }
//}
}