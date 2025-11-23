namespace Domain.Common
{
    public abstract class BaseEvent
    {
        public DateTime OccurredOnUtc { get; } = DateTime.UtcNow;
    }
}
