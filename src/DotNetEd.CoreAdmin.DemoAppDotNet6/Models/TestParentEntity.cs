using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetEd.CoreAdmin.DemoAppDotNet6.Models
{
    [Index(nameof(ChildId), Name = "IX_TestParentEntities_ChildId")]
    public partial class TestParentEntity
    {
        [Key]
        public Guid ParentId { get; set; }
        public Guid? ChildId { get; set; }
        
        [ForeignKey(nameof(ChildId))]
        public TestChildEntity Child { get; set; }
    }
}
