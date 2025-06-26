using System.Data;

namespace DbLibrary.DataBase
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
