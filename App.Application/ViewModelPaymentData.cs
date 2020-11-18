using System;

namespace App.Application
{
    public class ViewModelPaymentData
    {
        public Guid UserId { get; set; }
        public string sourceCurrency { get; set; }
        public string targetCurrency { get; set; }
        public decimal sourceValue { get; set; }
    }
}
