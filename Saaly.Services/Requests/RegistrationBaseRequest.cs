namespace Saaly.Services.Requests
{
    public class RegistrationBaseRequest
    {
        public bool AcceptTerms { get; set; }
        public required string UserName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string ConfirmPassword { get; set; }
    }
}
