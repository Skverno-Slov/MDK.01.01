using DbLibrary.DataBase;
using DbLibrary.Repositories;
using DbLibrary.Models;

string connectionString = "Data Source=mssql;Initial Catalog=ispp3114;Persist Security Info=True;User ID=ispp3114;Password=3114;Trust Server Certificate=True";
IDbConnectionFactory factory = new MsSqlFactory(connectionString);

GamesRepository repository = new GamesRepository(factory);
try
{
    repository.Create(new Game()
    {
        Title = "Dungeon Of Dangeon in Dangeon",
        Description = "Bla bla bla",
        Price = 999,
        PublicationYear = 2025
    });
}
catch
{
    Console.WriteLine("Ошибка при выполнении команды");
}