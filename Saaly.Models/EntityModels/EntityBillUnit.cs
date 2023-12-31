﻿using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.EntityModels
{
    public class EntityBillUnit : EntityBase, IHistoricalAuditable
    {
        [Required]
        public string Name { get; set; }
        [DisplayName("Bill-Unit Description")]
        [Required]
        public string? Description { get; set; }
    }
}