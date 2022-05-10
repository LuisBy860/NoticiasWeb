using Microsoft.EntityFrameworkCore;
using NoticiasWeb.Models;



namespace NoticiasWeb.Data
{

    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {

        }

        public DbSet<Categorias> Categorias { get; set; }
        public DbSet<Comentarios> Comentarios { get; set; }
        public DbSet<Noticias> Noticias { get; set; }

        public DbSet<Privilegios> Privilegios { get; set; }
        public DbSet<Suscripciónes> Suscripciónes { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

}