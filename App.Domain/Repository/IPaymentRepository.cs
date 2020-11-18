using System;
using System.Threading.Tasks;

namespace App.Domain.Repository
{
    public interface IPaymentRepository<T>
    {
        Task<decimal> GetSumByIdAsync<Guid>(Guid id);

        T GetByUserAccountAsync(Guid userAccount, DateTime dateTime);

        void Save(T payment, int expectedVersion);
       
    }
}
