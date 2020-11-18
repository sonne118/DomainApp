using MediatR;
using System;

namespace App.Domain.Core
{
    public abstract class Message : IRequest<Guid>
    {
        public string MessageType { get; protected set; }
        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
