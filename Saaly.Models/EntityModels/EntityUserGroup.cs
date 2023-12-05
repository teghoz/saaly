using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.EntityModels
{
    public class EntityUserGroup : EntityBase
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