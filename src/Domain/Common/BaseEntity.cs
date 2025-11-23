namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }

        private readonly List<BaseEvent> _domainEvents = new();

        public IReadOnlyCollection<BaseEvent> DomainEvents => _domainEvents.AsReadOnly();

        protected void AddDomainEvent(BaseEvent domainEvent)
        {
            _domainEvents.Add(domainEvent);
        }

        public void ClearDomainEvents()
        {
            _domainEvents.Clear();
        }
    }
}
