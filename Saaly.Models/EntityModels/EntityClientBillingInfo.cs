using Saaly.Models.Bases;
using SaalyModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityClientBillingInfo : EntityBase
    {
        public Guid? ContactGuid { get; set; }
        [ForeignKey("ContactGuid")]
        public Contact? Contact { get; set; }
        public Guid EntityClientGuid { get; set; }

        [ForeignKey("EntityClientGuid")]
        public EntityClient? EntityClient { get; set; }
    }
}