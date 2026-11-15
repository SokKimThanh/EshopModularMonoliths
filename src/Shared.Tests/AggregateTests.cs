using Shared.DDD;


namespace Shared.Tests
{
    public class AggregateTests
    {
        private sealed class TestAggregate : Aggregate<Guid>
        {
            public void Raise(IDomainEvent domainEvent)
            {
                AddDomainEvent(domainEvent);
            }
        }

        private sealed class TestDomainEvent : IDomainEvent
        {
            public Guid EventId => Guid.NewGuid();
            public DateTime OccurredOn => DateTime.UtcNow;
            public string EventType => GetType().AssemblyQualifiedName!;
        }

        [Fact]
        public void AddDomainEvent_ShouldAddEventToDomainEventsList()
        {
            // arrange
            var aggregate = new TestAggregate();
            // act
            aggregate.Raise(new TestDomainEvent());
            // assert
            Assert.Single(aggregate.DomainEvents);
        }
    }
}
