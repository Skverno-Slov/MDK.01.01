
using DbLibrary.Models;
using DbLibrary.Repositories;

namespace DbLibrary.Services
{
    public class GamesService(GamesRepository repository)
    {
        private readonly GamesRepository _repository = repository;
        private const string StartGettingMessage = "start getting..."; 
        private const string StopGettingMessage = "stop getting..."; 
        private const string StartCreatingMessage = "start creating..."; 
        private const string StopCreatingMessage = "game created..."; 
        private const string GameNotFoundMessage = "Game not found..."; 
        private const string StartUpdatingMessage = "start updating..."; 
        private const string StopUpdatingMessage = "stop updating...";
        private const string StartDeletingMessage = "start deleting...";
        private const string StopDeletingMessage = "game deleted..."; 
        
        public IEnumerable<Game> GetGames()
        {
            Console.WriteLine(StartGettingMessage);
            var games = _repository.GetAll();
            Console.WriteLine(StopGettingMessage);
            return games;
        }

        public Game GetGame(int id)
        {
            Console.WriteLine(StartGettingMessage);
            var game = _repository.GetById(id);
            if (game is null)
            {
                Console.WriteLine(GameNotFoundMessage);
                throw new KeyNotFoundException();
            }
                
            Console.WriteLine(StopGettingMessage);
            return game;
        }

        public void CreateGame(Game game)
        {
            Console.WriteLine(StartCreatingMessage);
            if (game is null)
            {
                Console.WriteLine(GameNotFoundMessage);
                throw new ArgumentNullException(nameof(game));
            }
                
            _repository.Create(game);
            Console.WriteLine(StopCreatingMessage);
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine(StartUpdatingMessage);
            if (game is null)
            {
                Console.WriteLine(GameNotFoundMessage);
                throw new ArgumentNullException(nameof(game));
            }

            _repository.Update(game);
            Console.WriteLine(StopUpdatingMessage);
        }

        public void DeleteGame(int id)
        {
            Console.WriteLine(StartDeletingMessage);
            _repository.Delete(id);
            Console.WriteLine(StopDeletingMessage);
        }
    }
}
