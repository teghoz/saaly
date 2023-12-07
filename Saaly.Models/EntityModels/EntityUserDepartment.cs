using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;

namespace Saaly.Models.EntityModels
{
    public class EntityUserDepartment : EntityBase, IHistoricalAuditable
    {
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
        public ICollection<EntityUserDepartmentClaim>? Claims { get; set; }
    }
}