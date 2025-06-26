using ApiService;
using DbLibrary.Models;

var client = new HttpClient()
{
    BaseAddress = new Uri("http://localhost:5122/api/")
};

GameService service = new(client);
try
{
    var games = await service.GetGamesAsync();
    Console.WriteLine("Игры получены");

    var game = await service.GetGamesByIdAsync(2);
    Console.WriteLine("Игра получена");
    game.Title = "Game1";
    await service.UpdateGameAsync(game);
    Console.WriteLine("Игра изменена");


    await service.CreateGameAsync(new Game
    {
        Title = "game15",
        Price = 100,
        PublicationYear = 2025
    });

    Console.WriteLine("Игра создана");
    await service.DeleteGameAsync(20);
    Console.WriteLine("Игра удалена");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();