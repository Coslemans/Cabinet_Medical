﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BD_Cabinet_Medical
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Cabinet_MedicalEntities : DbContext
    {
        public Cabinet_MedicalEntities()
            : base("name=Cabinet_MedicalEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Disease> Diseases { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<History_Patients> History_Patients { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }
        public virtual DbSet<Exemption> Exemptions { get; set; }
        public virtual DbSet<Internment_Tickets> Internment_Tickets { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
    }
}
