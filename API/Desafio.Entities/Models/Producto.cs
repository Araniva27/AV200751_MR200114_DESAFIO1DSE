using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int CategoriaId { get; set; }
        public string? Descripcion { get; set; }

        public Categoria Categoria { get; set; }
    }
}
