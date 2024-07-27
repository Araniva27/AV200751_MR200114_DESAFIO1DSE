using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio.Entities.Models;
namespace Desafio.DAL.Interfaces
{
    public interface IProductoRepository
    {
        public Task<Producto> Update(Producto producto);
    }
}
