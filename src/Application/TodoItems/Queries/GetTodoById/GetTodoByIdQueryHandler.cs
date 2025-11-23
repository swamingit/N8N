using Application.Common.Interfaces;
using MediatR;
//using Microsoft.EntityFrameworkCore;
using System.Data.Entity;

namespace Application.TodoItems.Queries.GetTodoById
{
    public sealed class GetTodoByIdQueryHandler : IRequestHandler<GetTodoByIdQuery, TodoDto?>
    {
        private readonly IApplicationDbContext _context;

        public GetTodoByIdQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<TodoDto?> Handle(GetTodoByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _context.TodoItems
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (entity is null)
            {
                return null;
            }

            return new TodoDto
            {
                Id = entity.Id,
                Title = entity.Title,
                IsCompleted = entity.IsCompleted
            };
        }
    }
}
