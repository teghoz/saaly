using Saaly.Data.Interfaces;
using Saaly.Data.Specifications;
using Saaly.Services.Requests;

namespace Saaly.Services.Admin
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Models.Admin> _adminRepository;

        public AdminService(IRepository<Models.Admin> adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<List<Models.Admin>?> GetAdmin(AdminRequest request)
        {
            var spec = new AdminByNameSpecification(request.Name, request.Skip, request.Take);
            return await _adminRepository.GetAll(spec);
        }
    }
}
