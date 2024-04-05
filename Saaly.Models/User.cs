using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models
{
    public class User : SaalyBase, IHistoricalAuditable
    {
        public Guid? ContactGuid { get; set; }
        [ForeignKey("ContactGuid")]
        public Contact? Contact { get; set; }

        [Required]
        [DisplayName("Employee Code")]
        public string Code { get; set; }
    }
}