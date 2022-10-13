namespace Data
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}