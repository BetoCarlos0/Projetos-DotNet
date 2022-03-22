using Livraria.Models.Categorias;
using System.Collections.Generic;

namespace Livraria.Categorias
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
        IEnumerable<Categoria> GetById(int id);
        void Create(Categoria entity);
        void Update(Categoria entity);
        //void Delete(Livro entity);
        void DeleteId(int id);
    }
}
