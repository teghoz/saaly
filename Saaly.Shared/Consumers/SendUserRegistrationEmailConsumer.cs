using MassTransit;
using Saaly.Shared.Messages;

namespace Saaly.Shared.Consumers
{
    public class SendUserRegistrationEmailConsumer : IConsumer<SendUserRegistrationEmail>
    {
        public Task Consume(ConsumeContext<SendUserRegistrationEmail> context)
        {
            throw new NotImplementedException();
        }
    }
}
