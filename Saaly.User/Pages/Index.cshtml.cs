using Microsoft.AspNetCore.Mvc.RazorPages;
using Saaly.Infrastructure.Extensions;
using Saaly.Infrastucture.Configurations;
using Saaly.Shared.Messages;

namespace SaalyUser.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger _logger;
        private readonly IMessagingService _messagingService;

        public IndexModel(ILogger<IndexModel> logger, IMessagingService messagingService)
        {
            _logger = logger;
            _messagingService = messagingService;
        }

        public async Task OnGet()
        {
            var message = new SendUserRegistrationEmail("A", "B", "C");
            await _messagingService.Send(message, new Uri("queue:" + SaalyConfig.Instance.Messaging.RegistrationQueue));
        }
    }
}