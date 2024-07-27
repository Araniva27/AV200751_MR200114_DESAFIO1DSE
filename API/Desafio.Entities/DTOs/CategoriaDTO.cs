using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities.DTOs
{
    public class CategoriaDTO
    {
        public int Codigo { get; set; }

        [Required(ErrorMessage = "El nombre de la categoría es requerido")]
        [StringLength(50, ErrorMessage = "El nombre de la categoría no puede tener mas de 50 caracteres")]
        public string NombreCategoria { get; set; }
        
        public string? DescripcionCategoria { get; set; }
    }
}
