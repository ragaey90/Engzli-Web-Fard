﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Engzli.Fard.Entities.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FardEntities : DbContext
    {
        public FardEntities()
            : base("name=FardEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<fm> fms { get; set; }
        public virtual DbSet<fm_health> fm_health { get; set; }
        public virtual DbSet<fm_passport> fm_passport { get; set; }
        public virtual DbSet<fm_study_work> fm_study_work { get; set; }
        public virtual DbSet<org_visitors> org_visitors { get; set; }
        public virtual DbSet<problems_reports> problems_reports { get; set; }
        public virtual DbSet<provider> providers { get; set; }
        public virtual DbSet<provider_associations> provider_associations { get; set; }
        public virtual DbSet<provider_distrbution> provider_distrbution { get; set; }
        public virtual DbSet<provider_family_needs> provider_family_needs { get; set; }
        public virtual DbSet<provider_health> provider_health { get; set; }
        public virtual DbSet<provider_house_assest> provider_house_assest { get; set; }
        public virtual DbSet<provider_income_eg> provider_income_eg { get; set; }
        public virtual DbSet<provider_passport> provider_passport { get; set; }
        public virtual DbSet<provider_researcher> provider_researcher { get; set; }
        public virtual DbSet<provider_residence> provider_residence { get; set; }
        public virtual DbSet<provider_study_work> provider_study_work { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<usersmg> usersmgs { get; set; }
    }
}
