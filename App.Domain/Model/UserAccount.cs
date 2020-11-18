using System;
using System.Collections.Generic;

namespace App.Domain.Model
{
    public class UserAccount
    {
        public Guid UserAccountId { get; private set; }
        public Guid UserId { get; private set; }
        public Currency Currency { get; private set; }
        public decimal AccountBalance { get; private set; }
        public string? Email { get; private set; }
        public bool? IsEmailNotification { get; private set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<BonusAccount> BonusAccounts { get; set; }

        public User User { get; set; }
        public int UserForeignKey { get; set; }

        private UserAccount()
        {
            // this.Payments = new HashSet<Payment>();
            //  this.BonusAccounts = new HashSet<BonusAccount>();
        }

        public UserAccount(Guid userId, Currency sourceCurrency)
        {
            this.UserId = userId;
            this.Currency = sourceCurrency;
        }

        public UserAccount(Guid userId, string email, Currency currency, decimal accountBalance)
        {
            this.UserId = userId;
            this.UserAccountId = Guid.NewGuid();
            this.AccountBalance = accountBalance;
            this.Currency = currency;
            this.Email = email;
            this.IsEmailNotification = false;
        }

        public void EmailNotification()
        {
            this.IsEmailNotification = true;
        }
    }
}
