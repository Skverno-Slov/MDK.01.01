using DbLibrary.DataBase;
using DbLibrary.Repositories;
using DbLibrary.Services;

string connectionString = "Data Source=mssql;Initial Catalog=ispp3114;Persist Security Info=True;User ID=ispp3114;Password=3114;Trust Server Certificate=True";
IDbConnectionFactory factory = new MsSqlFactory(connectionString);

GamesRepository repository = new(factory);
GamesService service = new(repository);

try
{
    var games = service.GetGames();
    var game = service.GetGame(3);
    service.CreateGame(new()
    {
        Title = "Dungeon Of Dungeon in Dungeon",
        Description = "Bla bla bla 123",
        Price = 999,
        PublicationYear = 2025
    });
    service.UpdateGame(new()
    {
        Id = 7,
        Title = "Dungeon Of Dungeon in Dungeon 2",
        Description = "Bla bla bla 123",
        Price = 9990,
        PublicationYear = 2026
    });
    service.DeleteGame(7);
}
catch
{
    Console.WriteLine("Ошибка выполнения команды");
}