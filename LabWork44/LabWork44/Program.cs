using Microsoft.Data.Sqlite;

string dataBaseName = "db2.sqlite";

CreateDatabase(dataBaseName);

static void CreateDatabase(string dataBaseName)
{
    if (!File.Exists(dataBaseName))
    {
        var fileName = Path.Combine(Environment.CurrentDirectory, dataBaseName);

        string connectionString = $"Data Source={fileName}";

        using SqliteConnection connection = new(connectionString);
        connection.Open();
        Console.WriteLine("Соединение установлено");

        var command = new SqliteCommand(@"CREATE TABLE Game (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Title TEXT NOT NULL,
            Description TEXT NULL,
            PublicationYear INTEGER NOT NULL,
            Price REAL NOT NULL);",
            connection);
        command.ExecuteNonQuery();

        command = new SqliteCommand(@"CREATE TABLE Review (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            GameId INTEGER NOT NULL,
            User TEXT NOT NULL,
            Comment TEXT NOT NULL,
            PublicationDate TEXT NOT NULL,
            FOREIGN KEY (GameId) REFERENCES Game(Id));",
            connection);
        command.ExecuteNonQuery();
        Console.WriteLine("Создана таблица");
    }
}