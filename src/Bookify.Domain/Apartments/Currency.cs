namespace Bookify.Domain.Apartments;

public record Currency
{
    internal static readonly Currency None = new(string.Empty);
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Eur = new("EUR");
    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, Eur };

    public string Code { get; init; }

    public Currency(string code) => Code = code;

    public static Currency FromCode(string code) =>
        All.FirstOrDefault(c => c.Code == code)
        ?? throw new ApplicationException($"Currency with code {code} not found");
}
