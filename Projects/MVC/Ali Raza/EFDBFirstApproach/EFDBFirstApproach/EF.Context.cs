﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFDBFirstApproach
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MVC_Concept_AcademyEntities : DbContext
    {
        public MVC_Concept_AcademyEntities()
            : base("name=MVC_Concept_AcademyEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Dept> tbl_Dept { get; set; }
        public virtual DbSet<tbl_Emp> tbl_Emp { get; set; }
        public virtual DbSet<tbl_Emps> tbl_Emps { get; set; }
    }
}