using Microsoft.EntityFrameworkCore;
namespace demo.Model
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options){ }

        public DbSet<Contratto> contrattos { get; set; }


        public DbSet<Cliente> clientes { get; set; }

        public DbSet<dipendenti> dipendentis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contratto>()
                        .HasKey(t => t.Id);
        }
    }
}
