using Domain.Common;

namespace Domain.Entities
{
    public class TodoItem : BaseEntity
    {
        public string Title { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }

        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
