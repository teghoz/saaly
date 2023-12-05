using Saaly.Models.Bases;
using SaalyShared.Enums;

namespace Saaly.Models.EntityModels
{
    public class Entity : SaalyBase
    {
        public eEntityTypes Types { get; set; }
    }
}