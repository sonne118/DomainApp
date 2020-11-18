using App.Domain.Repository;
using System;
using System.Threading.Tasks;

namespace App.Domain.Model
{
    public class BonusAccount
    {
        public Guid BonusAccountId { get; private set; }
        public Guid UserId { get; private set; }
        public Currency Currency { get; private set; }
        public Guid PaymentId { get; private set; }
        public DateTime DateTime { get; private set; }
        public decimal SumPerTransaction { get; private set; }
        public decimal? SumBonusPerTransaction { get; private set; }
        public UserAccount UserAccount { get; private set; }
        public int UserAccountForeignKey { get; private set; }


        private readonly IPaymentRepository<Payment> _paymentRepository;
        public BonusAccount(IPaymentRepository<Payment> paymentRepository)
        {
            _paymentRepository = paymentRepository;
        }
        internal BonusAccount(UserAccount userAccount, Payment payment, decimal amount, decimal amountPerTransaction)
        {
            this.BonusAccountId = Guid.NewGuid();
            this.Currency = userAccount.Currency;
            this.DateTime = DateTime.Now;
            this.PaymentId = payment.PaymentId;
            this.UserId = userAccount.UserId;
            this.SumPerTransaction = amountPerTransaction;
        }

        internal async Task CreateBonusPerTransactionTenPlusDay<Guid>(Guid payment, bool IsBonusToday)
        {
            await _paymentRepository.GetSumByIdAsync(payment);
        }

        public async Task CreateBonusPerTransactionFiveCurrencyDay<Guid>(Guid payment, bool IsBonusToday)
        {
            await _paymentRepository.GetSumByIdAsync(payment);
        }

        public void CancellationBonusAccount()
        {
            /// some canceled realize of code
        }
    }
}
