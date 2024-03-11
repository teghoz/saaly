using FluentValidation;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Saaly.Data;
using Saaly.Models;
using Saaly.Services.Requests;

namespace Saaly.Services.Validators
{
    public class RegistrationValidator : AbstractValidator<RegistrationBaseRequest>
    {
        private readonly SaalyContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public RegistrationValidator(SaalyContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;

            RuleFor(x => x.UserName).NotNull();
            RuleFor(x => x.UserName).MustAsync(async (userName, cancellation) =>
            {
                bool exists = await _context.Users.AnyAsync(u => u.UserName == userName);
                return !exists;
            }).WithMessage("UserName Must be unique");

            RuleFor(x => x.Email).MustAsync(async (email, cancellation) =>
            {
                bool exists = await _context.Users.AnyAsync(u => u.Email == email);
                return !exists;
            }).WithMessage("Email Already Exist");

            RuleFor(x => x).Must((model, cancellation) =>
            {
                var passwordDontMatch = model.Password != model.ConfirmPassword;
                return !passwordDontMatch;
            }).WithMessage("Password Mismatch");

            RuleFor(x => x).Must((model, cancellation) =>
            {
                if (_userManager.PasswordValidators.All(a => a.ValidateAsync(_userManager, null, model.Password).Result.Succeeded))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }).WithMessage("Password does not meet requirement");
        }
    }
}
