using System.Collections.Generic;

namespace App.Domain.ExchangeRate
{
    public interface ICurrencyExchange<T> 
    {
       List<T> GetConversionRates();
    }
}
