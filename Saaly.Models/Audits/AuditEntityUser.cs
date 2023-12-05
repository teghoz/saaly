﻿using Saaly.Models.Bases;
using SaalyModels;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saaly.Models.Audits
{
    public class AuditEntityUser : EntityBase
    {
        public Guid? ContactGuid { get; set; }

        [Required]
        [DisplayName("Employee Code")]
        public string Code { get; set; }

        [Required]
        [DisplayName("BillCode")]
        public Guid BillCodeGuid { get; set; }

        [DisplayName("Department")]
        public Guid? DepartmentGuid { get; set; }
        [DisplayName("Manager")]
        public Guid? ManagerGuid { get; set; }
    }
}