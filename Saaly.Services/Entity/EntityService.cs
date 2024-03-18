using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Data.Interfaces;
using Saaly.Data.Specifications;
using Saaly.Models;
using Saaly.Models.EntityModels;
using Saaly.Services.Requests;
using SaalyShared.Enums;

namespace Saaly.Services.Entity
{
    public class EntityService : IEntityService
    {
        private readonly SaalyContext _saalyContext;
        private readonly IRepository<EntityUser> _entityUserRepository;
        private readonly IRepository<Models.EntityModels.Entity> _entityRepository;

        public EntityService(SaalyContext saalyContext,
            IRepository<Models.EntityModels.Entity> entityRepository,
            IRepository<EntityUser> entityUserRepository)
        {
            _saalyContext = saalyContext;
            _entityUserRepository = entityUserRepository;
            _entityRepository = entityRepository;
        }

        public async Task<List<Models.EntityModels.Entity>?> GetEntities(int? skip, int? take)
        {
            var spec = new EntitySpecification(skip, take);
            return await _entityRepository.GetAll(spec);
        }

        public async Task<List<Models.EntityModels.Entity>?> GetUserEntities(Guid entityUserGuid, int? skip, int? take)
        {
            var spec = new EntityByUserSpecification(entityUserGuid, skip, take);
            var entityUsers = await _entityUserRepository.GetAll(spec);
            return entityUsers.Select(e => e.Entity).ToList();
        }

        public async Task<User> SetupNewUser(RegistrationBaseRequest request, string? name, bool status)
        {
            var entityUser = new EntityUser
            {
                Entity = new Models.EntityModels.Entity
                {
                    Type = eEntityTypes.Individual,
                    IsActive = status,
                    Name = name,
                },
                User = new User
                {
                    Contact = new Models.Contact
                    {
                        IsActive = status,
                        Email = request.Email,
                    },
                    IsActive = status,
                    Code = request.Email,
                },
                IsActive = status,
                Code = request.Email
            };

            await _saalyContext.EntityUsers.AddAsync(entityUser);
            await _saalyContext.SaveChangesAsync();

            entityUser.Entity.OwnerGuid = entityUser.UserGuid;
            await _saalyContext.SaveChangesAsync();
            return entityUser.User;
        }

        public async Task AddEntity(NewEntityRequest request)
        {
            var entityUser = await _saalyContext.EntityUsers
                .Where(u => u.Guid == request.EntityUserGuid)
                .FirstOrDefaultAsync();

            if (entityUser is null)
            {
                return;
            }


            var entity = new Models.EntityModels.Entity
            {
                Type = request.Type,
                IsActive = request.Status,
                Name = request.Name,
                OwnerGuid = request.OwnerGuid
            };

            await _saalyContext.Entities.AddAsync(entity);
            await _saalyContext.SaveChangesAsync();
        }
    }
}
