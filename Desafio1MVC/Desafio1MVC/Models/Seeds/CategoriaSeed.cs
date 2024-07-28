using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Desafio1MVC.Models.Seeds
{
    // Configuración inicial (seeding) para la entidad Categoria.
    public class CategoriaSeed : IEntityTypeConfiguration<Categoria>
    {
        // Método que configura los datos iniciales de la entidad Categoria.
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(
                new Categoria { Id = 1, Nombre = "Electrónica" },
                new Categoria { Id = 2, Nombre = "Ropa" },
                new Categoria { Id = 3, Nombre = "Alimentos" }
                );
        }
    }
}
