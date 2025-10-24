using System.Text.RegularExpressions;


namespace Domain.ValueObjects;


public sealed record PhoneNumber(string Value)
{
    private static readonly Regex Digits = new("^[0-9+][0-9]{6,14}$");


    public static PhoneNumber Create(string value)
    {
        if (string.IsNullOrWhiteSpace(value) || !Digits.IsMatch(value))
            throw new ArgumentException("Invalid phone number.");
        return new PhoneNumber(value);
    }
}