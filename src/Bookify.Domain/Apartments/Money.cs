namespace Bookify.Domain.Apartments;

public record Money(decimal Amount, Currency Currency)
{
    public static Money operator +(Money left, Money right)
    {
        if (left.Currency != right.Currency)
        {
            throw new InvalidOperationException("Cannot add money with different currencies");
        }

        return new Money(left.Amount + right.Amount, left.Currency);
    }

    public static Money Zero() => new(0, Currency.None);
}
