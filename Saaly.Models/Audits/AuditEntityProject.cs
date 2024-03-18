using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.Audits
{
    public class AuditEntityProject : AuditEntityBase
    {
        public Guid EntityProjectGuid { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Budget Hours")]
        public decimal BudgetHours { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public string ProjectID { get; set; }

        [DisplayName("Code")]
        public string Code { get; set; }

        [DisplayName("Chargeable")]
        public bool IsChargable { get; set; }

        [DisplayName("Client")]
        public Guid? ClientGuid { get; set; }
    }
}