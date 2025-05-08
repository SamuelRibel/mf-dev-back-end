using Microsoft.EntityFrameworkCore;

namespace mf_dev_back_end.Models
{
    public class AppDbCoontext : DbContext
    {
        public AppDbCoontext(DbContextOptions <AppDbCoontext> options) : base(options) { }

        public DbSet<Veiculo> Veiculos { get; set; }

        public DbSet<Consumo> Consumos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

    }
}
