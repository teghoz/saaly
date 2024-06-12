using Saaly.Models;

namespace Saaly.Services.Requests
{
    public class EntityClientRequest
    {
        public required Guid EntityGuid { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Contact? Contact { get; set; }
        public string? ManagementCompany { get; set; }
    }
}
