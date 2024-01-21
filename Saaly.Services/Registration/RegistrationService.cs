using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Requests;
using Saaly.Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saaly.Services.Registration
{
    public class RegistrationService(SaalyContext context, UserManager<ApplicationUser> userManager, IValidator<RegistrationBaseRequest> validator) : IRegistrationService
    {
        private readonly SaalyContext _context = context;
        private readonly UserManager<ApplicationUser> _userManager = userManager;

        public async Task Register(RegistrationBaseRequest request)
        {
            var validationResult = validator.ValidateAsync(request);
            if (validationResult.Result.IsValid)
            {
                var applicationUser = new ApplicationUser();
                applicationUser.Email = request.Email;
                applicationUser.UserName = request.UserName;

                var result = await _userManager.CreateAsync(applicationUser, request.Password);
                if (result is not null && result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(applicationUser, "Merchant");
                }
            }
        }
    }

}
