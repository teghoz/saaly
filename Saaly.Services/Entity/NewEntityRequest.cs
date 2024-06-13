using SaalyShared.Enums;

namespace Saaly.Services.Entity
{
    public class NewEntityRequest
    {
        public eEntityTypes Type { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public Guid UserGuid { get; set; }
        public Guid? OwnerGuid { get; internal set; }
    }
}
