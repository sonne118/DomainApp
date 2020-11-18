using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Model;
using App.Domain.Repository;

namespace App.Infrastructure.DataAccess.repo
{
    public class InMemoryUserRepository : IUserRepository<User>
    {
        public void AddAsync(User user)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
            //return Task.FromResult(_user.Single(i => i.Key == id).Value);
        }
    }
}
