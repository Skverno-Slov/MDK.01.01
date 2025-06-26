using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;

namespace DBlibrary
{
    public class SqliteDatabase : IDataBase
    {
        private readonly string _connectionString;

        public SqliteDatabase(string path, string fileName)
        {
            SqliteConnectionStringBuilder builder = new()
            {
                DataSource = Path.Combine(path, fileName)
            };

            _connectionString = builder.ConnectionString;
        }

        public int ExecuteQuery(string query)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();
            SqliteCommand command = new(query, connection);
            return command.ExecuteNonQuery();
        }

        public void InsertGame(string title, decimal price, int date)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();

            string query = @"INSERT TABLE Game VALUES Title = @Title, Price = @Price, PublicationYear = @PublicationYear";
            SqliteCommand command = new(query, connection);
            command.Parameters.AddWithValue("@PublicationYear", date);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Price", price);
        }

        public bool UpdateGame(int id, string title, decimal price)
        {
            using SqliteConnection connection = new(_connectionString);
            connection.Open();

            string query = @$"UPDATE Game SET Title = '{title}', Price = '{price}' WHERE Id = '{id}'";
            SqliteCommand command = new(query, connection);

            return command.ExecuteNonQuery() > 0;
        }
    }
}
