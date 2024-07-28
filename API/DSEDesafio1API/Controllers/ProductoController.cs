using Desafio.BL.Interfaces;
using Desafio.Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DSEDesafio1API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : Controller
    {
        private readonly IProductoService service;
        
        public ProductoController(IProductoService ProductoService)
        {
            this.service = ProductoService;
        }
        

        [HttpPut("{id}")]
        [ProducesResponseType(typeof(ProductoDTO), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> Update(int id, ProductoDTO producto)
        {
            if(producto == null)
            {
                return (IActionResult)this.BadRequest();
            }
            ProductoDTO result = await this.service.Update(producto, id);
            return (result != null) ? (IActionResult)this.Ok(result) : (IActionResult)this.BadRequest();
        }
        
    }
}
