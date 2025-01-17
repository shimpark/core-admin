﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetEd.CoreAdmin.DemoAppDotNet6.Models
{
    public partial class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(100)]
        public string Category { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        [System.ComponentModel.DataAnnotations.ScaffoldColumn(false)]
        public int Idx { get; set; }
    }
}
