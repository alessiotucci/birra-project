using Microsoft.EntityFrameworkCore;
namespace demo.Model
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options){ }

        public DbSet<Contratto> Contratti { get; set; }


        public DbSet<Cliente> Clienti { get; set; }

        public DbSet<Dipendenti> Dipendenti { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contratto>()
                        .HasKey(t => t.Id);


            modelBuilder.Entity<Cliente>()
                        .HasKey(c => c.Id);


            modelBuilder.Entity<Dipendenti>()
                        .HasKey(c => c.Id);
        }
    }
}
