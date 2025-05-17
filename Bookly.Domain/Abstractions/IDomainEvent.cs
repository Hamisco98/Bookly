using MediatR;

namespace Bookly.Domain.Abstractions;

public interface IDomainEvent : INotification
{
    // This interface can be used to mark domain events in the application.
    // It inherits from MediatR's INotification interface, which allows it to be published
    // and handled by MediatR handlers.
}
