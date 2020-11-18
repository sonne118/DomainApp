using System;
using System.Threading.Tasks;

namespace App.Domain.Repository
{
    public interface IUserAccountRepository<T>
    {
        Task<T> GetByIdAsync(Guid userId);

        void Add(T userAccount);
    }
}
