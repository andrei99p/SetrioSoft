using System.Linq.Expressions;

namespace BlazorApp1.Data.Repositories.Abstraction
{
    public interface IBaseRepository<T>
    {
        Task<IQueryable<T>> All();
        Task<IQueryable<T>> Find(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
