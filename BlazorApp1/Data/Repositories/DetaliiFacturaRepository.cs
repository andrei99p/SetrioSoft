using BlazorApp.Data.Models;
using BlazorApp.Data;
using BlazorApp1.Data.Repositories.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Data.Repositories
{
    public sealed class DetaliiFacturaRepository(IDbContextFactory<AppDbContext> dbContextFactory)
        : BaseRepository<DetaliiFactura>(dbContextFactory), IDetaliiFacturaRepository
    {
    }

    public interface IDetaliiFacturaRepository : IBaseRepository<DetaliiFactura> { }

}
