using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1MVC.Models.Seeds
{
    public class ProductoSeed : IEntityTypeConfiguration<Producto>
    {
        // Método que configura los datos iniciales de la entidad Producto.
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.HasData(
                new Producto { Id = 1, Nombre = "Smartphone", Precio = 299.99m, Stock = 50, CategoriaId = 1 },
                new Producto { Id = 2, Nombre = "Camisa", Precio = 19.99m, Stock = 200, CategoriaId = 2 },
                new Producto { Id = 3, Nombre = "Pan", Precio = 1.99m, Stock = 100, CategoriaId = 3 },
                new Producto { Id = 4, Nombre = "Laptop", Precio = 799.99m, Stock = 30, CategoriaId = 1 },
                new Producto { Id = 5, Nombre = "Zapatos", Precio = 49.99m, Stock = 150, CategoriaId = 2 }
                );
        }
    }
}
