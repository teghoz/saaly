﻿using Saaly.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityClient : EntityBase
    {
        [Required]
        [DisplayName("Client Name")]
        public string Name { get; set; }

        [DisplayName("Mngt. Company")]
        [RegularExpression("^[a-zA-Z -][a-zA-Z0-9 -]*$", ErrorMessage = "Management Company only accepts Alphanumeric inputs")]
        public string? ManagementCompany { get; set; }

        public Guid? ContactGuid { get; set; }
        [ForeignKey("ContactGuid")]
        public Contact? Contact { get; set; }

        public Guid? EntityClientBillingInfoGuid { get; set; }
        [ForeignKey("EntityClientBillingInfoGuid")]
        public EntityClientBillingInfo? EntityClientBillingInfo { get; set; }
    }
}