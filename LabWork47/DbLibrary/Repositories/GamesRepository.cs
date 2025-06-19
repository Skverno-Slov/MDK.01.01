using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLibrary.DataBase;
using DbLibrary.Models;
using Dapper;
using static Dapper.SqlMapper;

namespace DbLibrary.Repositories
{
    public class GamesRepository(IDbConnectionFactory factory)
    {
        private readonly IDbConnection _connection = factory.CreateConnection();

        public IEnumerable<Game> GetAll()
            => _connection.Query<Game>("SELECT * FROM Game");

        public Game? GetById(int id)
            => _connection.QueryFirstOrDefault<Game>("SELECT * FROM Game WHERE Id=@id", new { id });

        public void Create(Game game)
            => _connection.Execute(@"INSERT INTO Game (Title, Description, Price, PublicationYear)
            VALUES (@Title, @Description, @Price, @PublicationYear)", game);

        public void Update(Game game)
            => _connection.Execute(@"UPDATE Game
SET Title = @Title
    ,Description = @Description
    ,Price = @Price
    ,PublicationYear = @PublicationYear
WHERE Id = @Id", game);

        public void Delete(int id)
            => _connection.Execute("DELETE FROM Game WHERE Id = @Id", new { id });
    }

}
