namespace Domain.ValueObjects;


public sealed record PassengerName(string FullName)
{
    public static PassengerName Create(string fullName)
    {
        if (string.IsNullOrWhiteSpace(fullName) || fullName.Trim().Length < 2)
            throw new ArgumentException("Passenger name is required.");
        return new PassengerName(fullName.Trim());
    }
}