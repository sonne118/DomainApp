using App.Domain.Core;
using App.Domain.Model;
using System;

namespace App.Domain.Payments
{
    public  class PaymentCreatedCommand : Command
    {
        public UserAccount _userAccount;

        public Guid _user;

        public Currency _sourceCurrency;

        public Currency _targetCurrency;

        public MoneyValue _sourceValue;

        public PaymentCreatedCommand(Guid user, UserAccount userAccount, Currency sourceCurrency, Currency targetCurrency,decimal sourceValue)
        {
            this._user = user;
            this._sourceCurrency = sourceCurrency;
            this._userAccount =  userAccount;
            this._targetCurrency = targetCurrency;
            this._sourceValue = new MoneyValue(sourceValue, sourceCurrency);
        }
    }
}
