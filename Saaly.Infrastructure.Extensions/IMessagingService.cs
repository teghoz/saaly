
namespace Saaly.Infrastructure.Extensions
{
    public interface IMessagingService
    {
        Task Send<T>(T message, Uri address);
    }
}