using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.DAL.Interfaces
{
    public interface IDatabaseRepository
    {                
        public Task<T> Update<T>(string storeProcedure, DynamicParameters? parameters = null);       
    }
}
