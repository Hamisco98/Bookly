using Bookly.Domain.Users.ValueObjects;
using Bookly.Domain.Users.Events;
using Bookly.Domain.Abstractions;

namespace Bookly.Domain.Users;

public sealed class User : Entity
{
    private User(Guid Id, FirstName firstName, LastName lastName, Email email) 
    : base(Id)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
    }

    public FirstName FirstName { get; private set; }
    public LastName LastName { get; private set; }
    public Email Email { get; private set; }

    public static User Create(FirstName firstName, LastName lastName, Email email)
    {
        var user = new User(Guid.NewGuid(), firstName, lastName, email);

        user.RaiseDomainEvent(new UserCreatedDomainEvent(user.Id));

        return user;
    }
}
