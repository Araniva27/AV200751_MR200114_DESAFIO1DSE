using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Desafio1MVC.Models
{
    public class Producto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Es necesario ingresar el nombre del producto")]
        [StringLength(50, MinimumLength = 4)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Es necesario ingresar el precio del producto")]
        [Range(0.01, double.MaxValue, ErrorMessage = "El precio debe ser mayor a 0.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }

        [Required(ErrorMessage = "Es necesario ingresar la cantidad en stock del producto")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock no puede ser negativo.")]
        public int Stock { get; set; }

        [Required(ErrorMessage = "Es necesario ingresar la categoria del producto")]
        [ForeignKey("Categoria")]
        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }

        public string? Descripcion { get; set; }
    }
}
