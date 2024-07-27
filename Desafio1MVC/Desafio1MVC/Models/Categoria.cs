using System.ComponentModel.DataAnnotations;

namespace Desafio1MVC.Models
{
    public class Categoria
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Es neceario ingresar el nombre de la categoria")]
        [StringLength(50, MinimumLength = 4)]
        public string Nombre { get; set; }

        public string? Descripcion { get; set; }

        public ICollection<Producto> Productos { get; set; }
    }
}
