using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Entity;
using Saaly.Services.Requests;

namespace Saaly.Services.Registration
{
    public class RegistrationService(SaalyContext context, UserManager<ApplicationUser> userManager,
        IValidator<RegistrationBaseRequest> validator, IEntityService entityService, ILogger<RegistrationService> logger) : IRegistrationService
    {
        private readonly SaalyContext _context = context;
        private readonly ILogger _logger = logger;
        private readonly UserManager<ApplicationUser> _userManager = userManager;
        private readonly IEntityService _entityService = entityService;

        public async Task<IdentityResult?> Register(RegistrationBaseRequest request)
        {
            IdentityResult? result = null;
            var validationResult = validator.ValidateAsync(request);

            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    if (validationResult.Result.IsValid)
                    {
                        var user = await _entityService.SetupNewUser(request, request.UserName, true);
                        var applicationUser = new ApplicationUser();
                        applicationUser.Email = request.Email;
                        applicationUser.UserName = request.UserName;
                        applicationUser.UserGuid = user.Guid;

                        result = await _userManager.CreateAsync(applicationUser, request.Password);
                        if (result is not null && result.Succeeded)
                        {
                            await _userManager.AddToRoleAsync(applicationUser, "User");
                            await transaction.CommitAsync();
                        }
                    }
                }
                catch (DbUpdateException ex)
                {
                    _logger.LogError(string.Empty, ex);
                    // Log or handle database update exceptions
                    result = null;
                    await transaction.RollbackAsync();
                    // Handle error or throw an exception
                }
                catch (Exception ex)
                {
                    _logger.LogError(string.Empty, ex);
                    result = null;
                    // Handle other exceptions
                    await transaction.RollbackAsync();
                    // Handle error or throw an exception
                }
            }
            return result;
        }
    }
}
