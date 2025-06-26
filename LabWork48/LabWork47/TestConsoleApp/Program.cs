using DbLibrary.DataBase;
using DbLibrary.Repositories;
using DbLibrary.Models;

string connectionString = "Data Source=mssql;Initial Catalog=ispp3114;Persist Security Info=True;User ID=ispp3114;Password=3114;Trust Server Certificate=True";
IDbConnectionFactory factory = new MsSqlFactory(connectionString);

GamesRepository repository = new(factory);
try
{
    repository.Create(new Game()
    {
        Title = "Dungeon Of Dungeon in Dungeon",
        Description = "Bla bla bla 123",
        Price = 999,
        PublicationYear = 2025
    });
    Console.WriteLine("Строка создана");

    var games = repository.GetAll();
}
catch
{
    Console.WriteLine("Ошибка при выполнении команды");
}