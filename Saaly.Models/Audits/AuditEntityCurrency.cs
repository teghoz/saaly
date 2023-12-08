using Saaly.Models.Bases;

namespace Saaly.Models.Audits
{
    public class AuditEntityCurrency : EntityBase
    {
        public string? FullName { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? IsoCode { get; set; }
        public string? Symbol { get; set; }
        public string? FractionalUnit { get; set; }
    }
}