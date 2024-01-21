using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Saaly.Services.Recaptcha;
using Saaly.Services.Registration;
using Saaly.Services.Requests;
using Saaly.Shared.Helpers;

namespace SaalyUser.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly ILogger _logger;
        private readonly ICaptchaService _captchaService;
        private readonly IRegistrationService _registrationService;
        private readonly IValidator<RegistrationBaseRequest> _registrationValidator;

        public RegisterModel(ILogger<RegisterModel> logger, ICaptchaService captchaService, IRegistrationService registrationService,
            IValidator<RegistrationBaseRequest> registrationValidator)
        {
            _logger = logger;
            _captchaService = captchaService;
            _registrationService = registrationService;
            _registrationValidator = registrationValidator;
        }

        [TempData]
        public string? StatusMessage { get; set; }

        [BindProperty]
        public RegistrationBaseRequest RequestModel { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            var token = Request.Form["g-recaptcha-response"];
            var recaptchaResult = await _captchaService.Verify(token);

            if (!RequestModel.AcceptTerms)
            {
                StatusMessage = StatusHelper.Feedbacks(m =>
                {
                    m.FeedbackType = eFeedbackType.Custom;
                    m.Type = eStatusType.Error;
                    m.Messages.Add("Please Accept Terms and Conditions");
                });

                return Page();
            }

            if (!recaptchaResult)
            {
                StatusMessage = StatusHelper.Feedbacks(m =>
                {
                    m.FeedbackType = eFeedbackType.Custom;
                    m.Type = eStatusType.Error;
                    m.Messages.Add("Invalid Recaptcha");
                });

                return Page();
            }

            var validationResult = await _registrationValidator.ValidateAsync(RequestModel);
            if (!validationResult.IsValid)
            {
                //var errors = string.Join(", ", validationResult.Errors.Select(e => e.ErrorMessage).ToList());
                //var feedbacks = validationResult.Errors;

                StatusMessage = StatusHelper.Feedbacks(m =>
                {
                    m.FeedbackType = eFeedbackType.Custom;
                    m.Type = eStatusType.Error;
                    m.Messages = validationResult.Errors.Select(e => e.ErrorMessage).ToList();
                });

                return Page();
            }

            await _registrationService.Register(RequestModel);

            return RedirectToAction("Index");
        }
    }
}