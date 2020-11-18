using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Model;
using App.Domain.Repository;

namespace App.Infrastructure.DataAccess.repo
{
    public class InMemoryUserAccountRepository : IUserAccountRepository<UserAccount>
    {
        public void Add(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }

        public Task<UserAccount> GetByIdAsync(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
