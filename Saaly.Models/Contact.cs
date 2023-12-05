using Saaly.Models.Bases;
using Saaly.Models.EntityModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class Contact : SaalyBase
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? FullName => $@"{FirstName} {LastName}";
        public string? Code { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? WhatsappNumber { get; set; }
        public Guid? GenderGuid { get; set; }
        public string? Address { get; set; }
        [Url]
        public string? Website { get; set; }
        public Guid? LocationGuid { get; set; }
        [ForeignKey("LocationGuid")]
        public virtual EntityLocation? Location { get; set; }
        [ForeignKey("GenderGuid")]
        public virtual EntityGender? Gender { get; set; }
    }
}