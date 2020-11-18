using App.Domain.Model;
using System;
using System.Threading.Tasks;

namespace App.Domain.Repository
{
    public interface IBonusAccountRepository
    {
        Task<BonusAccount> GetByIdAsync(Guid BonusAccountId);

        void AddAsync(BonusAccount bonusAccount);
    }
}
