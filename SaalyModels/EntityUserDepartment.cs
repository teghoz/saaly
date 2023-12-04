using Saaly.Models;
using System.ComponentModel;

namespace SaalyModels
{
    public class EntityUserDepartment : EntityBase
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