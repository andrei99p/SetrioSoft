using BlazorApp.Data;
using BlazorApp.Data.Models;
using BlazorApp1.Data.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Repositories
{
    public sealed class FacturaRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        :BaseRepository<Factura>(dbContextFactory), IFacturaRepository
    {
    }

    public interface IFacturaRepository : IBaseRepository<Factura> { }
}
