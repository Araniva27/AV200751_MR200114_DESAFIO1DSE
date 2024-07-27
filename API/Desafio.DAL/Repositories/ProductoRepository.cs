using Dapper;
using Desafio.DAL.Interfaces;
using Desafio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.DAL.Repositories
{
    public class ProductoRepository: IProductoRepository
    {
        private readonly IDatabaseRepository databaseRepository;

        public ProductoRepository(IDatabaseRepository repository)
        {
            this.databaseRepository = repository;
        }

        public async Task<Producto> Update(Producto producto)
        {
            string query = "UPDATE Productos SET Stock = @Stock WHERE Id = @Id";
            var parameters = new DynamicParameters();
            parameters.Add("@Stock", producto.Stock);
            parameters.Add("@Id", producto.Id);
            return await databaseRepository.Update<Producto>(query, parameters);
        }
    }
}
