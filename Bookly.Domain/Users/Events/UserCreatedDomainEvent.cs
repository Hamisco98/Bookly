using Bookly.Domain.Abstractions;

namespace Bookly.Domain.Users.Events;

public record UserCreatedDomainEvent(Guid Id) : IDomainEvent;