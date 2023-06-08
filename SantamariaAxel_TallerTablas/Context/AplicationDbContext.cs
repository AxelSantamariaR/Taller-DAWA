using Biblioteca;
using Microsoft.EntityFrameworkCore;

namespace SantamariaAxel_TallerTablas.Context
{  
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options) { }

        public DbSet<Genero> Generos { get; set; } 

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
