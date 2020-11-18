using App.Domain.Model;

namespace App.Domain.ExchangeRate
{
    public sealed class ConversionRate  
    {
        public ConversionRate(Currency sourceCurrency, Currency targetCurrency, decimal factor)
        {
            this.SourceCurrency = sourceCurrency;
            this.TargetCurrency = targetCurrency;
            this.Factor = factor;         
        }

        public Currency SourceCurrency { get;}
        public Currency TargetCurrency { get;}
        public decimal Factor { get; set; }

        internal MoneyValue Convert(MoneyValue value)
        {
            return this.Factor * value;
        }
    }
}
