using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Model;
using App.Domain.Repository;

namespace App.Infrastructure.DataAccess.repo
{
    public class InMemoryBonusAccountRepository : IBonusAccountRepository
    {
        public void AddAsync(BonusAccount bonusAccount)
        {
            throw new NotImplementedException();
        }

        public Task<BonusAccount> GetByIdAsync(Guid BonusAccountId)
        {
            throw new NotImplementedException();
        }
    }
}
