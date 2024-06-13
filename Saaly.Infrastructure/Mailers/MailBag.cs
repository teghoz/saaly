namespace Saaly.Infrastructure.Mailers
{
    public class MailBag
    {
        public string? Email { get; set; }
        public string? HtmlBody { get; set; }
        public string? Template { get; set; }
        public string? Subject { get; set; }
        public string? Sender { get; set; }
    }
}