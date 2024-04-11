namespace Saaly.Services.Requests
{
    public class EntityBillUnitRequest
    {
        public required Guid EntityGuid { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}
