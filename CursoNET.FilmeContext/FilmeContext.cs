using CursoNET.FilmeContext.Model;
using FilmesApi.Domain;
using Microsoft.EntityFrameworkCore;

namespace CursoNET.FilmeContext
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)
        {
            
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
