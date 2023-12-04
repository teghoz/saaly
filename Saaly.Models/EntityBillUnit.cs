using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SaalyModels
{
    public class EntityBillUnit : Entity
    {
        [Required]
        public string Name { get; set; }
        [DisplayName("Bill-Unit Description")]
        [Required]
        public string? Description { get; set; }
    }
}