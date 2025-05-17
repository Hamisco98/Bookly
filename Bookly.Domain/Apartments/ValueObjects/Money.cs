namespace Bookly.Domain.Apartments.ValetObjects;

public record Money(decimal Amount, Currency Currency)
{

    public static Money None => new(0, Currency.None);
}