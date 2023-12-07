using Saaly.Models.Bases;
using Saaly.Models.Interfaces;

namespace Saaly.Models.EntityModels
{
    public class EntityGender : EntityBase, IHistoricalAuditable
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}