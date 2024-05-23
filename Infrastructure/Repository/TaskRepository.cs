using Application.Repository;
using Infrastructure.Context;

namespace Infrastructure.Repository
{
    public class TaskRepository<T> : IRepository<T> where T : class
    {
        private readonly TaskContext _context;

        public TaskRepository(TaskContext context)
        {
            _context = context;
        }
        public T Add(T entity)
        {
            _context.Add(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(string id)
        {
            T entity = _context.Set<T>().Find(id) ?? throw new Exception("Not Found");
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();

        }

        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(string id)
        {
            return _context.Set<T>().Find(id)!;
        }

        public T Update(T entity)
        {
            _context.Set<T>().Update(entity);
            _context.SaveChanges();
            return entity;
        }
    }
}
