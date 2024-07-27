using Desafio1MVC.Models.Seeds;
using Microsoft.EntityFrameworkCore;

namespace Desafio1MVC.Models
{
    public class InventarioDbContext : DbContext
    {
        public InventarioDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoriaSeed());
            modelBuilder.ApplyConfiguration(new ProductoSeed());
        }
    }
}
