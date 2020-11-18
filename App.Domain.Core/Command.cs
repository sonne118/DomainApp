using System;
using System.Collections.Generic;
using System.Text;

namespace App.Domain.Core
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }
        public Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
