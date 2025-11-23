using Application.Common.Interfaces;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public sealed class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems => Set<TodoItem>();

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            // Add audit or outbox logic here if needed
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
