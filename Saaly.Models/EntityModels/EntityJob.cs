﻿using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Saaly.Models.EntityModels
{
    public class EntityJob : EntityBase, IHistoricalAuditable
    {
        [DisplayName("Job Type")]
        [Required]
        public string Type { get; set; }
        [DisplayName("Job Description")]
        [Required]
        public string? Description { get; set; }
    }
}