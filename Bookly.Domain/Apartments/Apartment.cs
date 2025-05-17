
using Bookly.Domain.Apartments.ValetObjects;
using Bookly.Domain.Apartments.Enums;
using Bookly.Domain.Abstractions;


namespace Bookly.Domain.Apartments;

public sealed class Apartment : Entity
{
    public Apartment(
        Guid id
        , Name name
        , Description description
        , Address address
        , Money pricePerNight
        , Money cleaningFee
        , Money serviceFee
        , Money securityDeposit
        , MaxGuests maxGuests
        , Bedrooms bedrooms
        , Bathrooms bathrooms
        , Status status
        , List<Amenities> amenities)
        : base(id)
    {
        Name = name;
        Description = description;
        Address = address;
        PricePerNight = pricePerNight;
        CleaningFee = cleaningFee;
        ServiceFee = serviceFee;
        SecurityDeposit = securityDeposit;
        MaxGuests = maxGuests;
        Bedrooms = bedrooms;
        Bathrooms = bathrooms;
        Status = status;
        Amenities = amenities;
    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }

    public Address Address { get; private set; }

    public Money PricePerNight { get; private set; }
    public Money CleaningFee { get; private set; }
    public Money ServiceFee { get; private set; }
    public Money SecurityDeposit { get; private set; }

    public MaxGuests MaxGuests { get; private set; }
    public Bedrooms Bedrooms { get; private set; }
    public Bathrooms Bathrooms { get; private set; }

    public DateTime? LsatBookedOnUTC { get; private set; }

    public Status Status { get; private set; }
    public List<Amenities> Amenities { get; private set; } = new();
}

