using FatInterface.Core.Interfaces.Repositories;
using FatInterface.Core.Interfaces.Services;

namespace FatInterface.Core.Services
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private readonly IGenericRepository<T> _genericRepository;

        public GenericService()
        {
            
        }

        public GenericService(IGenericRepository<T> genericRepository)
        {
            _genericRepository = genericRepository;
        }

        public void Add(T entity)
        {
            _genericRepository.Add(entity);
        }

        public void Delete(T entity)
        {
            _genericRepository?.Delete(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public T GetById(int id)
        {
            return _genericRepository.GetById(id);
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
        }
    }
}
