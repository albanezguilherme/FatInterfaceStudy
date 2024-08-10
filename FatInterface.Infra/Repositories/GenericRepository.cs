using FatInterface.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FatInterface.Infra.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly DbSet<T> _entities;
        private readonly FatInterfaceContext _context;

        public GenericRepository()
        {
            
        }
        public GenericRepository(FatInterfaceContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public void Add(T entity)
        {
            _entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.ToList();
        }

        public T GetById(int id)
        {
            return _entities.FirstOrDefault();
        }

        public void Update(T entity)
        {
            _entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
