﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace qlsv.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DBDOANWINEntities3 : DbContext
    {
        public DBDOANWINEntities3()
            : base("name=DBDOANWINEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Nganh> Nganhs { get; set; }
        public virtual DbSet<QLDA> QLDAs { get; set; }
        public virtual DbSet<QLDASV> QLDASVs { get; set; }
        public virtual DbSet<QLGV> QLGVs { get; set; }
        public virtual DbSet<QLSV> QLSVs { get; set; }
        public virtual DbSet<QLUser> QLUsers { get; set; }
        public virtual DbSet<The_Loai> The_Loai { get; set; }
        public virtual DbSet<Tien_do> Tien_do { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
