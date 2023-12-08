using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.Audits
{
    public class AuditEntityJob : EntityBase
    {
        [DisplayName("Job Type")]
        [Required]
        public string Type { get; set; }
        [DisplayName("Job Description")]
        [Required]
        public string? Description { get; set; }
    }
}