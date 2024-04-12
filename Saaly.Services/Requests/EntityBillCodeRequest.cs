using Saaly.Models.EntityModels;

namespace Saaly.Services.Requests
{
    public class EntityBillCodeRequest
    {
        public required Guid EntityGuid { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<EntityBillCodeCurrencyRate>? CurrencyRates { get; set; }
    }
}
