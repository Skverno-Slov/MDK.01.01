using Microsoft.Data.SqlClient;

namespace DBlibrary
{
    public class SqlDatabase : IDataBase
    {
        private string _connectionString;

        public SqlDatabase(string serverName,
                           string dataBaseName,
                           string login,
                           string password)
        {
            SqlConnectionStringBuilder builder = new()
            {
                DataSource = serverName,
                InitialCatalog = dataBaseName,
                UserID = login,
                Password = password
            };

            _connectionString = builder.ConnectionString;
        }

        public int ExecuteQuery(string query = @"UPDATE Game
            SET price += 1;") // проверить запрос
        {
            using SqlConnection connection = new(_connectionString);
            try
            {
                connection.Open();
                SqlCommand command = new(query, connection);
                return command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
               throw new ApplicationException("Ошибка при выполении запроса", exception);
            }
        }
    }
}
