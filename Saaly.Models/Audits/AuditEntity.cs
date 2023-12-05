using Saaly.Models.Bases;
using SaalyShared.Enums;

namespace Saaly.Models.Audits
{
    public class AuditEntity : SaalyBase
    {
        public eEntityTypes Types { get; set; }
    }
}