using Microsoft.EntityFrameworkCore;
using mvcDotCore.Models;

namespace mvcDotCore.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext (DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; } //conjunto entidades (Tabla) # Entidad (fila)
    }
}