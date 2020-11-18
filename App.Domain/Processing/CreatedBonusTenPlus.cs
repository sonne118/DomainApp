using App.Domain.Core;
using App.Domain.Model;
using MediatR.Pipeline;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace App.Domain.Processing
{
    public class CreatedBonusTenPlus : IRequestPostProcessor<Command, Guid>
    {
        private readonly BonusAccount _bonusAccount;
        public CreatedBonusTenPlus(BonusAccount bonusAccount)
        {
            this._bonusAccount = bonusAccount;
        }
        public async Task Process(Command request, Guid response, CancellationToken cancellationToken)
        {
            try
            {
                await _bonusAccount.CreateBonusPerTransactionTenPlusDay(response, true);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
