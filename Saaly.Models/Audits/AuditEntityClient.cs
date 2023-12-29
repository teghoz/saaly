using Saaly.Models.Bases;
using System.ComponentModel;

namespace Saaly.Models.Audits
{
    public class AuditEntityClient : AuditEntityBase
    {
        public Guid EntityClientGuid { get; set; }
        [DisplayName("Client Name")]
        public string Name { get; set; }

        [DisplayName("Mngt. Company")]
        public string? ManagementCompany { get; set; }

        public Guid? ContactGuid { get; set; }
        public Contact? Contact { get; set; }
        public Guid? EntityClientBillingInfoGuid { get; set; }
    }
}