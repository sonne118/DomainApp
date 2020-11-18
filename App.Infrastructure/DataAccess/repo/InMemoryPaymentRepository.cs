using App.Domain.Model;
using App.Domain.Repository;
using System;
using System.Threading.Tasks;

namespace App.Infrastructure.DataAccess.repo
{
    public class InMemoryPaymentRepository : IPaymentRepository<Payment>
    {
        public Payment GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Payment GetByUserAccountAsync(Guid userAccount, DateTime dateTime)
        {
            throw new NotImplementedException();
        }

        public Task<decimal> GetSumByIdAsync<Guid>(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(Payment payment, int expectedVersion)
        {
            throw new NotImplementedException();
        }
    }
}
