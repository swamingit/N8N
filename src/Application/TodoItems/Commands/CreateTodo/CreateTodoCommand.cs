using MediatR;

namespace Application.TodoItems.Commands.CreateTodo
{
    public sealed class CreateTodoCommand : IRequest<Guid>
    {
        public string Title { get; set; } = string.Empty;
    }
}
