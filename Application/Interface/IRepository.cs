namespace Application.Repository
{
    public interface IRepository<T> where T : class
    {
        T GetById(string id);
        IEnumerable<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        void Delete(string id);
    }
}
