using Desafio1MVC.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Desafio1MVC.Models
{
    // Clase de contexto de Entity Framework Core para la base de datos de inventario.
    public class InventarioDbContext : DbContext
    {
        // Constructor que recibe las opciones de configuración del contexto.
        public InventarioDbContext(DbContextOptions options) : base(options)
        {

        }
        // Definición de las tablas en la base de datos como conjuntos de entidades (DbSet).
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        // Configuración adicional del modelo mediante el método OnModelCreating.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aplica configuraciones iniciales (seeding) para las tablas Categoria y Producto.
            modelBuilder.ApplyConfiguration(new CategoriaSeed());
            modelBuilder.ApplyConfiguration(new ProductoSeed());
        }
    }
}
