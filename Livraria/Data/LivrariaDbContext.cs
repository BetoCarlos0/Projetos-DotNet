using Livraria.Models.Categorias;
using Livraria.Models.Livros;
using Microsoft.EntityFrameworkCore;

namespace Livraria.Data
{
    public class LivrariaDbContext : DbContext
    {
        public LivrariaDbContext(DbContextOptions<LivrariaDbContext> options) : base(options)
        {

        }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
    }
}
