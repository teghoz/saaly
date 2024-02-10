using MassTransit;
using MassTransit.Transports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Infrastructure.Extensions
{
    public class MessagingService : IMessagingService
    {
        private readonly ISendEndpointProvider _sendEndpointProvider;
        public MessagingService(ISendEndpointProvider sendEndpointProvider)
        {
            _sendEndpointProvider = sendEndpointProvider;
        }
        public async Task Send<T>(T message, Uri address)
        {
            var endpoint = await _sendEndpointProvider.GetSendEndpoint(address);
            await endpoint.Send(message);
        }
    }
}
