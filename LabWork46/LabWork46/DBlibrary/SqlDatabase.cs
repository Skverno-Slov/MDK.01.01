using Microsoft.Data.SqlClient;

namespace DBlibrary
{
    public class SqlDatabase : IDataBase
    {
        private readonly string _connectionString;

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
                Password = password,
                TrustServerCertificate = true
            };

            _connectionString = builder.ConnectionString;
        }

        public int ExecuteQuery(string query)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            SqlCommand command = new(query, connection);
            return command.ExecuteNonQuery();
        }

        public void InsertGame(string title, decimal price, int date)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string query = @"INSERT TABLE Game VALUES Title = @Title, Price = @Price, PublicationYear = @PublicationYear";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@PublicationYear", date);
            command.Parameters.AddWithValue("@Title", title);
            command.Parameters.AddWithValue("@Price", price);
        }

        public bool UpdateGame(int id, string title, decimal price)
        {
            using SqlConnection connection = new(_connectionString);
            connection.Open();

            string query = $@"UPDATE Game SET Title = '{title}', Price = '{price}' WHERE Id = '{id}'";
            SqlCommand command = new(query, connection);

            return command.ExecuteNonQuery() > 0;
        }

        
    }
}
