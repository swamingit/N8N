namespace Application.TodoItems.Queries.GetTodoById
{
    public sealed class TodoDto
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }
    }
}
