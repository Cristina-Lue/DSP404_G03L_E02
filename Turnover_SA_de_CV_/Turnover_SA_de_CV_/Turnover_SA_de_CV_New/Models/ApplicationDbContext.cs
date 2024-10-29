using System.Data.Entity;

namespace Turnover_SA_de_CV_.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=SistemaVentaEntradasDB")  // Especifica explícitamente el nombre
        {
            Database.SetInitializer<ApplicationDbContext>(new CreateDatabaseIfNotExists<ApplicationDbContext>());
        }

        public DbSet<Concierto> Conciertos { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}