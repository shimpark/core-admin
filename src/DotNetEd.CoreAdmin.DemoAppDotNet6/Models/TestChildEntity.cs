﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetEd.CoreAdmin.DemoAppDotNet6.Models
{
    public partial class TestChildEntity
    {
        public TestChildEntity()
        {
            TestParentEntities = new HashSet<TestParentEntity>();
        }

        [Key]
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        [InverseProperty(nameof(TestParentEntity.Child))]
        public virtual ICollection<TestParentEntity> TestParentEntities { get; set; }
    }
}
