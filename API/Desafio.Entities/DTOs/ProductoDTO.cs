using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities.DTOs
{
    public class ProductoDTO
    {
        //public int Codigo { get; set; }

        //[Required(ErrorMessage = "El nombre del producto es requerido")]
        //[MaxLength(50,ErrorMessage = "El nombre del producto no puede contener más de 50 caracteres")]
        //public string NombreProducto { get; set; }
        //public double PrecioProducto { get; set; }
        public int StockProducto { get; set; }

    }
}
