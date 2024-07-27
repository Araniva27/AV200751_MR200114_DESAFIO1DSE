using AutoMapper;
using Desafio.BL.Interfaces;
using Desafio.DAL.Interfaces;
using Desafio.Entities.DTOs;
using Desafio.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.BL.Services
{
    public class ProductoService: IProductoService
    {
        private readonly IProductoRepository repository;
        private readonly IMapper mapper;

        public ProductoService(IProductoRepository repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public async Task<ProductoDTO> Update(ProductoDTO model)
        {
            try
            {
                var entity = mapper.Map<ProductoDTO, Producto>(model);
                var result = await repository.Update(entity);
                return mapper.Map<Producto, ProductoDTO>(result);
            }catch (Exception ex)
            {
                return null;
            }
        }
    }
}
