using System.Net.Http.Json;
using DbLibrary.Models;

namespace ApiService
{
    public class GameService(HttpClient httpClient)
    {
        private readonly HttpClient _httpClient = httpClient;
    
        public async Task<IEnumerable<Game>?> GetGamesAsync()
            => await _httpClient.GetFromJsonAsync<IEnumerable<Game>>("Games");

        public async Task<Game?> GetGamesByIdAsync(int id)
            => await _httpClient.GetFromJsonAsync<Game>($"Games/{id}");

        public async Task UpdateGameAsync(Game game)
        {
            var responce = await _httpClient.PutAsJsonAsync($"Games/{game.Id}", game);
            responce.EnsureSuccessStatusCode();
        }

        public async Task DeleteGameAsync(int id)
        {
            var responce = await _httpClient.DeleteAsync($"Games/{id}");
            responce.EnsureSuccessStatusCode();
        }

        public async Task CreateGameAsync(Game game)
        {
            var responce = await _httpClient.PostAsJsonAsync($"Games", game);
            responce.EnsureSuccessStatusCode();
        }
    }
}
