
using Microsoft.Data.SqlClient;

namespace MSSQLLibrary

{
    public static class MSSQLDataAccessLayer
    {
        public static string ServerName { get; set; } = "mssql";
        public static string DBName { get; set; } = "ispp3114";
        public static string Login { get; set; } = "ispp3114";
        public static string Password { get; set; } = "3114";

        public static string ConnectionString
        {
            get
            {
                SqlConnectionStringBuilder builder = new()
                {
                    DataSource = ServerName,
                    InitialCatalog = DBName,
                    UserID = Login,
                    Password = Password,
                };
                return builder.ConnectionString;
            }
        }
    }
}

