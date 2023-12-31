﻿using Saaly.Models.Bases;
using Saaly.Models.Interfaces;
using System.ComponentModel;

namespace Saaly.Models.EntityModels
{
    public class EntityClientGroup : EntityBase, IHistoricalAuditable
    {
        public string Name { get; set; }
        [DisplayName("Description")]
        public string? Description { get; set; }
        [DisplayName("Groups Has Capacity")]
        public bool HasMaximumCapacity { get; set; }
        public int MaximumCapacity { get; set; }
        [DisplayName("Code")]
        public string Code { get; set; }
        public ICollection<EntityClientGroupClient>? Clients { get; set; }
    }
}