using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityUserDepartmentClaim : EntityBase, IHistoricalAuditable
    {
        public Guid EntityUserDepartmentGuid { get; set; }
        public string? Name { get; set; }
        [ForeignKey("EntityUserDepartmentGuid")]
        public EntityUserDepartment? EntityUserDepartment { get; set; }
    }
}