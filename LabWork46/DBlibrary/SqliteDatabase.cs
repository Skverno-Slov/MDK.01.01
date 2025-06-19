using Microsoft.Data.Sqlite;

namespace DBlibrary
{
    public class SqliteDatabase : IDataBase
    {
        private string _connectionString;

        public SqliteDatabase(string path, string fileName)
        {
            SqliteConnectionStringBuilder builder = new()
            {
                DataSource = Path.Combine(path, fileName)
            };

            _connectionString = builder.ConnectionString;
        }

        public int ExecuteQuery(string query = @"UPDATE Game
            SET price += 1;") // проверить запрос
        {
            try
            {
                using SqliteConnection connection = new(_connectionString);
                connection.Open();
                SqliteCommand command = new(query, connection);
                return command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw new ApplicationException("Ошибка при выполении запроса", exception);
            }
        }
    }
}
