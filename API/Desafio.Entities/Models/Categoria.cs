using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio.Entities.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }
        public String Nombre { get; set; }
        public string? Descripcion {  get; set; } 
    }
}
