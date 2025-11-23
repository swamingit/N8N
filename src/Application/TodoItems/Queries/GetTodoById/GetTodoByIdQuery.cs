using MediatR;

namespace Application.TodoItems.Queries.GetTodoById
{
    public sealed class GetTodoByIdQuery : IRequest<TodoDto?>
    {
        public Guid Id { get; set; }
    }
}
