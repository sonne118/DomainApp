using App.Domain.Model;

namespace App.Domain
{
    public class MoneyValue
    {
        public decimal Value { get; }

        public Currency Currency { get; }

        public MoneyValue(decimal value, Currency currency)
        {
            this.Value = value;
            this.Currency = currency;
        }
        public static MoneyValue operator *(decimal number, MoneyValue moneyValueRight)
        {
            return new MoneyValue(number * moneyValueRight.Value, moneyValueRight.Currency);
        }
    }
}
