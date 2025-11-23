using Application.Common.Interfaces;
using Domain.Entities;
using MediatR;
using System.Data.Entity;

namespace Application.TodoItems.Commands.CreateTodo
{
    public sealed class CreateTodoCommandHandler : IRequestHandler<CreateTodoCommand, Guid>
    {
        private readonly IApplicationDbContext _context;

        public CreateTodoCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> Handle(CreateTodoCommand request, CancellationToken cancellationToken)
        {
            var entity = new TodoItem
            {
                Title = request.Title,
                IsCompleted = false
            };

            // Fix: Replace AllAsync with AddAsync to correctly add the entity to the DbSet
            //await _context.TodoItems.AddAsync(entity, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
