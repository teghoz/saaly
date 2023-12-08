using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using SaalyShared.Enums;

namespace Saaly.Models.EntityModels
{
    public class Entity : SaalyBase, IHistoricalAuditable
    {
        public eEntityTypes Types { get; set; }
    }
}