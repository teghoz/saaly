using Saaly.Models.Bases;
using Saaly.Models.Interfaces;

namespace Saaly.Models.EntityModels
{
    public class EntityCurrency : EntityBase, IHistoricalAuditable
    {
        public string? FullName { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public string? IsoCode { get; set; }
        public string? Symbol { get; set; }
        public string? FractionalUnit { get; set; }
    }
}