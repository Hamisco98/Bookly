namespace Bookly.Domain.Apartments.ValetObjects;

public record Address(
    string Street,
    string City,
    string State,
    string ZipCode,
    string Country
)
{
    public override string ToString() => $"{Country}, {State}, {City} | {ZipCode}, {Street}";
}