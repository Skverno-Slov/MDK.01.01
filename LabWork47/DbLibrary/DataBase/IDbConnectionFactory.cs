using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DbLibrary.DataBase
{
    public interface IDbConnectionFactory
    {
        IDbConnection CreateConnection();
    }
}
