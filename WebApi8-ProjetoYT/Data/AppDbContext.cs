using Microsoft.EntityFrameworkCore;
using WebApi8_ProjetoYT.Models;

namespace WebApi8_ProjetoYT.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base(options)
        {    
        }

        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
