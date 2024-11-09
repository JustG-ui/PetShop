using Microsoft.EntityFrameworkCore;
using PetShop.Models;

namespace PetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }

    
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Empregados> Fabricantes { get; set; }
        public DbSet<Servicos> Modelos { get; set; }
        public DbSet<Animais> Veiculo { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
            .HasKey(vl => new { vl.clienteId});
        }
    }
}
