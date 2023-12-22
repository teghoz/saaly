using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.EntityModels
{
    public class EntityClientBillingInfo : EntityBase, IHistoricalAuditable
    {
        public Guid? ContactGuid { get; set; }
        [ForeignKey("ContactGuid")]
        public Contact? Contact { get; set; }
        public Guid EntityClientGuid { get; set; }

        [ForeignKey("EntityClientGuid")]
        public EntityClient? EntityClient { get; set; }
    }
}