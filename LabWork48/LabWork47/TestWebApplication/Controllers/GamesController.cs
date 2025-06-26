using DbLibrary.Models;
using DbLibrary.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TestWebApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController(GamesRepository repository) : ControllerBase
    {
        private readonly GamesRepository _repository = repository;
        private const string errorMessage = "Ошибка выполнения команды";

        // GET: api/<GamesController>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_repository.GetAll());
            }
            catch
            {
                return BadRequest(errorMessage);
            }
        }

        // GET api/<GamesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                var game = _repository.GetById(id);
                return game is null ? NotFound() : Ok(game);
            }
            catch
            {
                return BadRequest(errorMessage);
            }

        }

        // POST api/<GamesController>
        [HttpPost]
        public IActionResult Post([FromBody] Game game)
        {
            try
            {
                if (game is null)
                    throw new ArgumentNullException(nameof(game));

                _repository.Create(game);
                return Created();
            }
            catch
            {
                return BadRequest(errorMessage);
            }
        }

        // PUT api/<GamesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Game game)
        {
            try
            {
                if (game is null)
                    throw new ArgumentNullException(nameof(game));

                if (id != game.Id)
                    return NotFound();

                _repository.Update(game);
                return NoContent();
            }
            catch
            {
                return BadRequest(errorMessage);
            }
        }

        // DELETE api/<GamesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _repository.Delete(id);
                return NoContent();
            }
            catch
            {
                return BadRequest(errorMessage);
            }
        }
    }
}
