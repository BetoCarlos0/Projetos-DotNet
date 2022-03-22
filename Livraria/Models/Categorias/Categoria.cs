using Livraria.Models.Livros;
using System.Collections.Generic;

namespace Livraria.Models.Categorias
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Livro> Livros { get; set; }

    }
}
