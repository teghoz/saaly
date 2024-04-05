using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Requests;

namespace Saaly.Services.Entity
{
    public interface IEntityService
    {
        Task<List<Models.EntityModels.Entity>?> GetEntities(int? skip, int? take);
        Task<List<Models.EntityModels.Entity>?> GetUserEntities(Guid entityUserGuid, int? skip, int? take);
        Task AddEntity(NewEntityRequest request);
        Task<User> SetupNewUser(RegistrationBaseRequest request, string? name, bool status);
    }
}