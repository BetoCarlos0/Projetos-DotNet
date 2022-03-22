using Livraria.Data;
using Livraria.Models.Livros;
using System;
using System.Collections.Generic;

namespace Livraria.Livros
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly ICategoriaRepository _ilivroRepository;
        private readonly LivrariaDbContext _dbContext;
        
        public CategoriaRepository(ICategoriaRepository ilivroRepository, LivrariaDbContext dbcontext)
        {
            _ilivroRepository = ilivroRepository;
            _dbContext = dbcontext;
        }

        public void Create(Livro entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> GetAll()
        {
            return _ilivroRepository.GetAll();
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Livro entity)
        {
            throw new NotImplementedException();
        }
    }
}
