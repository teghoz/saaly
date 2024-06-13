namespace Saaly.Services.Requests
{
    public class EntityCurrencyRequest
    {
        public required Guid EntityGuid { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string? FractionalUnit { get; set; }
        public string? FullName { get; set; }
        public string? ShortName { get; set; }
        public string? Symbol { get; set; }
    }
}
