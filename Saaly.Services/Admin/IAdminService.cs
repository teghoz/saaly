using Saaly.Services.Requests;

namespace Saaly.Services.Admin
{
    public interface IAdminService : IBaseService
    {
        Task<List<Models.Admin>?> GetAdmin(AdminRequest request);
    }
}