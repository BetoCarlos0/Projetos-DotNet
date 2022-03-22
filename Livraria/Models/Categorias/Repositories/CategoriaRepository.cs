using Livraria.Data;
using Livraria.Models.Categorias;
using System;
using System.Collections.Generic;

namespace Livraria.Categorias
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

        public void Create(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Categoria> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
