namespace Saaly.Shared.Messages
{
    public record SendUserRegistrationEmail(string Username, string Email, string VerificationLink);
}
