using System.Threading.Tasks;

namespace App.Domain.Repository
{
    public interface IUserRepository<T>
    {
        Task<T> GetByIdAsync(int id);
        void AddAsync(T user);
    }
}
