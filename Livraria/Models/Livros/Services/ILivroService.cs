using Livraria.Models.Livros;
using System.Collections.Generic;

namespace Livraria.Livros
{
    public interface ILivroService
    {
        //Livro GetById(int id);

        IEnumerable<Livro> GetAll();
        IEnumerable<Livro> GetById(int id);
        void Create(Livro entity);
        void Update(Livro entity);
        //void Delete(Livro entity);
        void DeleteId(int id);
    }
}
