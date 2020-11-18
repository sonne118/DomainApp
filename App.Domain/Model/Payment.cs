using App.Domain.ExchangeRate;
using App.Domain.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Domain.Model
{
    public class Payment
    {
        public Guid PaymentId { get; private set; }
        public Currency SourceCurrency { get; private set; }
        public Currency TargetCurrency { get; private set; }
        public MoneyValue SourceValue { get; private set; }
        public MoneyValue TargetValue { get; private set; }
        public DateTime CreateDate { get; private set; }
        public PaymentStatus Status { get; private set; }
        public bool IsRemoved { get; private set; }
        public bool? IsEmailNotification { get; private set; }
        public UserAccount UserAccount { get; private set; }
        public int UserAccountForeingKey { get; private set; }

        public Payment(MoneyValue sourceValue, Currency sourceCurrency, Currency targerCurrency, UserAccount _userAccount, List<ConversionRate> conversionRates)
        {
            this.PaymentId = Guid.NewGuid();
            this.UserAccount = _userAccount;
            this.CreateDate = DateTime.UtcNow;
            this.SourceCurrency = sourceCurrency;
            this.TargetCurrency = targerCurrency;
            this.SourceValue = sourceValue;
            this.Status = PaymentStatus.ToPay;
            this.IsRemoved = false;
            this.IsEmailNotification = false;
          //  this.CalculateValue(sourceValue, targerCurrency, conversionRates);
            this.EmailNotification();
        }

        public Task<MoneyValue> CalculateValue(MoneyValue sourceValue, Currency targetCurrency, List<ConversionRate> conversionRates)
        {
            if (targetCurrency != SourceCurrency)
            {
                var conversionRate = conversionRates.Single(i => i.SourceCurrency == SourceCurrency && i.TargetCurrency == targetCurrency);
                TargetValue = conversionRate.Convert(sourceValue);
                return Task.FromResult(TargetValue);
            }
            else
            {
                TargetValue = sourceValue;
                return Task.FromResult(TargetValue);
            }
        }

        public void EmailNotification()
        {
            IsEmailNotification = true;
        }
    }
}
