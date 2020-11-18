using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using App.Domain.Core;

namespace App.Infa.Bus
{
    class InMemoryBus : IMediatorHandler
    {

        private readonly IMediator _mediator;
        public InMemoryBus(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Domain.Core.Command
        {
            return _mediator.Send(command);
        }

    }
}
