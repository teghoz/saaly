﻿using Saaly.Models.Bases;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaalyModels
{
    public class EntityExpense : EntityBase
    {
        public int ID { get; set; }
        public Guid? WorkGuid { get; set; }
        public Guid ClientGuid { get; set; }
        public Guid UserGuid { get; set; }
        public DateTime Date { get; set; }
        public string Day { get; set; }
        public string Type { get; set; }
        public string Comments { get; set; }
        public int Amount { get; set; }
        [ForeignKey("UserGuid")]
        public EntityUser User { get; set; }
        [ForeignKey("ClientGuid")]
        public EntityClient Client { get; set; }
        [ForeignKey("WorkGuid")]
        public EntityWorkAssignment WorkAssignment { get; set; }
    }
}