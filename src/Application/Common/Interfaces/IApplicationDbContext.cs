using Domain.Entities;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<TodoItem> TodoItems { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
