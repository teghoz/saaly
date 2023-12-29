using Saaly.Data.Interfaces;
using Saaly.Data.Specifications;
using Saaly.Models;
using Saaly.Services.Requests;

namespace Saaly.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository<Admin> _adminRepository;

        public AdminService(IRepository<Admin> adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public async Task<List<Admin>?> GetAdmin(AdminRequest request)
        {
            var spec = new AdminByNameSpecification(request.Name, request.Skip, request.Take);
            return await _adminRepository.GetAll(spec);
        }
    }
}
