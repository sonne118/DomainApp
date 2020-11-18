using App.Domain.ExchangeRate;
using App.Domain.Model;
using App.Domain.Repository;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace App.Domain.Payments
{
    public  class PaymentCommandHandler : IRequestHandler<PaymentCreatedCommand, Guid>
    {

        private readonly ICurrencyExchange<ConversionRate> _currencyExchange;
        private readonly IPaymentRepository<Payment> _paymentRepository;
        public PaymentCommandHandler(ICurrencyExchange<ConversionRate> currencyExchange, IPaymentRepository<Payment> paymentRepository)
        {

            ICurrencyExchange<ConversionRate> _currencyExchange = currencyExchange;
            IPaymentRepository<Payment> _paymentRepository = paymentRepository;

        }
        public Task<Guid> Handle(PaymentCreatedCommand request, CancellationToken cancellationToken)
        {
            var conversionRates = _currencyExchange.GetConversionRates();
            var payment = new Payment(request._sourceValue,
                                     request._sourceCurrency,
                                     request._targetCurrency,
                                     request._userAccount,
                                     conversionRates);
           // payment.CalculateValue();

            //_unitOfWork.CommitAsync();

            return Task.FromResult(payment.PaymentId);
        }
    }
}
