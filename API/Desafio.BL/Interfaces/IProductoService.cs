using Desafio.Entities.DTOs;
using Desafio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.BL.Interfaces
{
    public interface IProductoService
    {
        public Task<ProductoDTO> Update(ProductoDTO producto);
    }
}
