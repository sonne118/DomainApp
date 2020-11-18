using System.Threading.Tasks;

namespace App.Application
{
    public interface IPaymentSevice
    {
        public Task PaymentCreated(ViewModelPaymentData request);
        public Task CreatedBonus();

    }
}
