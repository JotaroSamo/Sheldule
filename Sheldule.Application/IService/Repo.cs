namespace Sheldule.Application.IService;

public interface Repo<T> where T :class
{
    public Task<T> Create(T entity);
    public Task Delete(T entity);
    public Task<T> GetById(T entity);
    public Task<List<T>> GetList();
    public Task<T> Update(T entity);

}