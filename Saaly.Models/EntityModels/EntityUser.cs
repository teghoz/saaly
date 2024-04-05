using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityUser : EntityBase, IHistoricalAuditable
    {
        public Guid? UserGuid { get; set; }
        [ForeignKey("UserGuid")]
        public User? User { get; set; }

        [Required]
        [DisplayName("Employee Code")]
        public string Code { get; set; }

        [DisplayName("BillCode")]
        public Guid? BillCodeGuid { get; set; }

        [DisplayName("Department")]
        public Guid? DepartmentGuid { get; set; }
        [DisplayName("Manager")]
        public Guid? ManagerGuid { get; set; }
        [ForeignKey("ManagerGuid")]
        public virtual EntityUser? Manager { get; set; }
        [ForeignKey("DepartmentGuid")]
        public virtual EntityUserDepartment? EntityUserDepartment { get; set; }
        [ForeignKey("BillCodeGuid")]
        public virtual EntityBillCode? EntityBillCode { get; set; }
        public virtual List<EntityUserGroupUser>? Groups { get; set; }
    }
}