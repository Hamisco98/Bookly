namespace Bookly.Domain.Apartments.ValetObjects;

public record Currency
{
    // Variable to hold the currency code
    internal static readonly Currency None = new("");
    public static readonly Currency USD = new("USD");
    public static readonly Currency EUR = new("EUR");


    // Collection of all supported currencies
    public static readonly IReadOnlyCollection<Currency> All = new[]
    {
        USD,
        EUR
    };


    // Private constructor
    private Currency(string code)
    {
        // Validate the currency code
        if (string.IsNullOrWhiteSpace(code))
            throw new ArgumentException("Currency code cannot be null or empty.", nameof(code));

        // Validate the currency code length
        if (code.Length != 3)
            throw new ArgumentException("Currency code must be exactly 3 characters long.", nameof(code));

        // Set the currency code
        Code = code;
    }



    // Properties
    public string Code { get; init; }


    // Puclic methods
    public static Currency FromCode(string code)
    {
        // Validate the currency code, then return the corresponding Currency instance
        return All.FirstOrDefault(c => c.Code.Equals(code))
            ?? throw new ApplicationException($"Currency code '{code}' is not supported.");
    }

    // Override the ToString method to return the currency code
    public override string ToString() => Code;
}