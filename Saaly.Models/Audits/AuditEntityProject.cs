using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.Audits
{
    public class AuditEntityProject : EntityBase
    {
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        //[Required]
        [RegularExpression("([1-9][0-9]*)", ErrorMessage = "Budget Hours must be a natural number")]
        [DisplayName("Budget Hours")]
        public decimal BudgetHours { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [DisplayName("Start Date")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayName("End Date")]
        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        [Required]
        public string ProjectID { get; set; }

        [Required]
        [DisplayName("Code")]
        public string Code { get; set; }

        [Required]
        [DisplayName("Chargeable")]
        public bool IsChargable { get; set; }

        [Required]
        [DisplayName("Client")]
        public Guid ClientGuid { get; set; }
    }
}