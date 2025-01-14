﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DotNetEd.CoreAdmin.DemoAppDotNet6.Models
{
    public partial class ChinookContext : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<TestAutogeneratedKeyEntity> TestAutogeneratedKeyEntities { get; set; }
        public virtual DbSet<TestChildEntity> TestChildEntities { get; set; }
        public virtual DbSet<TestEntitiesWithImage> TestEntitiesWithImages { get; set; }
        public virtual DbSet<TestEntity> TestEntities { get; set; }
        public virtual DbSet<TestParentEntity> TestParentEntities { get; set; }

        public ChinookContext()
        {
        }

        public ChinookContext(DbContextOptions<ChinookContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Idx).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TestAutogeneratedKeyEntity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestChildEntity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestEntitiesWithImage>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestEntity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();
            });

            modelBuilder.Entity<TestParentEntity>(entity =>
            {
                entity.Property(e => e.ParentId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
