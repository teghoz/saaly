using Saaly.Models.Bases;
using Saaly.Models.Enums;

namespace Saaly.Models.Audits
{
    public class AuditEntityLocation : EntityBase
    {
        public string? Title { get; set; }
        public string? Slug { get; set; }
        public Guid? ParentGuid { get; set; }
        public eLocationDepth Depth { get; set; }
        public int SortOrder { get; set; }
        public string? MapData { get; set; }
    }
}