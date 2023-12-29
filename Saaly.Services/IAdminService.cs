using Saaly.Models;
using Saaly.Services.Requests;

namespace Saaly.Services
{
    public interface IAdminService : IBaseService
    {
        Task<List<Admin>?> GetAdmin(AdminRequest request);
    }
}