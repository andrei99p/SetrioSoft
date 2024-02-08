using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BlazorApp1.Data.Repositories.Abstraction
{
    public abstract class BaseRepository<T>(IDbContextFactory<AppDbContext> dbContextFactory) : IBaseRepository<T>
        where T : class
    {
        protected IDbContextFactory<AppDbContext> ContextFactory { get; set; } = dbContextFactory;


        public async Task<IQueryable<T>> All()
        {
            var data = await ContextFactory.CreateDbContextAsync();
            return data.Set<T>().AsNoTracking();
        }

        public async Task Create(T entity)
        {
            var data = await ContextFactory.CreateDbContextAsync();
            await data.Set<T>().AddAsync(entity);
            await data.SaveChangesAsync();
        }

        public async Task Delete(T entity)
        {
            var data = await ContextFactory.CreateDbContextAsync();
            data.Set<T>().Remove(entity);
            await data.SaveChangesAsync();
        }
        public async Task Update(T entity)
        {
            var data = await ContextFactory.CreateDbContextAsync();
            data.Set<T>().Update(entity);
            await data.SaveChangesAsync();
        }

        public async Task<IQueryable<T>> Find(Expression<Func<T, bool>> expression)
        {
            var data = await ContextFactory.CreateDbContextAsync();
            return data.Set<T>().Where(expression).AsNoTracking();
        }
    }
}
