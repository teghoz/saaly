using MassTransit;
using Saaly.Shared.Messages;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Shared.Consumers
{
    public class SendUserRegistrationEmailConsumer : IConsumer<SendUserRegistrationEmail>
    {
        public Task Consume(ConsumeContext<SendUserRegistrationEmail> context)
        {
            //context.
            throw new NotImplementedException();
        }
    }
}
