using App.Domain.Core;
using App.Domain.Model;
using App.Domain.Payments;
using App.Domain.Repository;
using System;
using System.Threading.Tasks;

namespace App.Application
{
    public sealed class PaymentSevice : IPaymentSevice
    {

        private readonly IMediatorHandler _bus;
        private readonly IUserRepository<User> _userRepository;

        public PaymentSevice(IMediatorHandler bus, IUserRepository<User> userRepository)
        {
            _bus = bus;
            _userRepository = userRepository;
        }
        public Task CreatedBonus()
        {

            // TO DO
            return Task.CompletedTask;
        }

        public async Task PaymentCreated(ViewModelPaymentData request)
        {
            var createPayCommand = new PaymentCreatedCommand(
                  request.UserId,
                  new UserAccount(request.UserId, (Currency)Enum.Parse(typeof(Currency), request.sourceCurrency)),
                  (Currency)Enum.Parse(typeof(Currency), request.sourceCurrency),
                  (Currency)Enum.Parse(typeof(Currency), request.targetCurrency),
                  request.sourceValue
                );
           await  _bus.SendCommand(createPayCommand);
        }
    }
}

