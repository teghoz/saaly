using Saaly.Models.Bases;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SaalyModels
{
    public class EntityJob : EntityBase
    {
        [DisplayName("Job Type")]
        [Required]
        public string Type { get; set; }
        [DisplayName("Job Description")]
        [Required]
        public string? Description { get; set; }
    }
}