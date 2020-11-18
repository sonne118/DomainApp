using App.Domain.Model;
using System.Collections.Generic;

namespace App.Domain.ExchangeRate
{
    public sealed class CurrencyExchange : ICurrencyExchange<ConversionRate>
    {
        public List<ConversionRate> GetConversionRates()
        {
            var conversionRates = new List<ConversionRate>();

            conversionRates.Add(new ConversionRate(Currency.USD, Currency.EUR, (decimal)0.85));
            conversionRates.Add(new ConversionRate(Currency.EUR, Currency.USD, (decimal)1.11));

            return conversionRates;
        }
    }
}
