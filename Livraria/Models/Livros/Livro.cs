using Livraria.Models.Categorias;
using System;

namespace Livraria.Models.Livros
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string Titulo { get; set; }
        public string Editora { get; set; }
        public string Autor { get; set; }
        public long Isbn { get; set; }
        public int Paginas { get; set; }
        public int Edicao { get; set; }
        public int AnoEdicao { get; set; }
        public string Pais { get; set; }
        public Categoria Categoria { get; set; }

        /*public Livro(int livroId, string titulo, string editora, string autor, long isbn, int paginas, int edicao, int anoEdicao, string pais, Categoria categoria)
        {
            LivroId = livroId;
            Titulo = titulo;
            Editora = editora;
            Autor = autor;
            Isbn = isbn;
            Paginas = paginas;
            Edicao = edicao;
            AnoEdicao = anoEdicao;
            Pais = pais;
            Categoria = categoria;
        }*/
    }
}
