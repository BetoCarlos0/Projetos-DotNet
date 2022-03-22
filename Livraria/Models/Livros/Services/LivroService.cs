using Livraria.Models.Livros;
using System.Collections.Generic;

namespace Livraria.Livros
{
    public class LivroService : ILivroService
    {
        private readonly ILivroService _service;

        public LivroService(ILivroService service)
        {
            _service = service;
        }

        public void Create(Livro entity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Livro> GetAll()
        {
            return _service.GetAll();
            throw new System.NotImplementedException();
        }

        public IEnumerable<Livro> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Livro entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
