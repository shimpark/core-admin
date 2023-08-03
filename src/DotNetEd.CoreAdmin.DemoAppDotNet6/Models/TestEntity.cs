using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DotNetEd.CoreAdmin.DemoAppDotNet6.Models
{
    public partial class TestEntity
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(3000)]
        public string Body { get; set; }
        public int EnumName { get; set; }
        public double Price { get; set; }
        public DateTime DateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTimeOffset DateTimeOffset { get; set; }
        public bool IsUseful { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal DecimalValue { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal? NullableDecimalValue { get; set; }
        public DateTime? NullableDateTimeValue { get; set; }
        public int? NullableIntValue { get; set; }
        public long? NullableLongValue { get; set; }
        public long LongValue { get; set; }
        public double DoubleValue { get; set; }
        public double? NullableDoubleValue { get; set; }
        public DateTimeOffset? NullableDateTimeOffsetValue { get; set; }
    }
}
