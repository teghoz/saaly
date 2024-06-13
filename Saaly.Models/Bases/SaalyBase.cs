using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Bases
{
    public class SaalyBase : IAuditable
    {
        public SaalyBase()
        {
            Created = DateTime.UtcNow;
            Modified = DateTime.UtcNow;
        }

        [ValidateNever]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Key]
        public Guid Guid { get; set; } = Guid.NewGuid();
        public bool IsActive { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public DateTime? Deleted { get; set; }
        public Guid? CreatedByUser { get; set; }
        public Guid? ModifiedByUser { get; set; }
        public Guid? DeletedByUser { get; set; }
    }
}
