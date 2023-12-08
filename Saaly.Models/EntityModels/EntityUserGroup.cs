using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;

namespace Saaly.Models.EntityModels
{
    public class EntityUserGroup : EntityBase, IHistoricalAuditable
    {
        [DisplayName("Group")]
        public string Name { get; set; }
        [DisplayName("Groups Description")]
        public string? Description { get; set; }
        public bool HasMaximumCapacity { get; set; }
        [DisplayName("Groups Maximum Capacity")]
        public int MaximumCapacity { get; set; }
        [DisplayName("Groups Code")]
        public string Code { get; set; }
    }
}