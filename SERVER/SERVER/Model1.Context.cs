﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SERVER
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TimeBankEntities : DbContext
    {
        public TimeBankEntities()
            : base("name=TimeBankEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Domains> Domains { get; set; }
        public virtual DbSet<FreeTime> FreeTime { get; set; }
        public virtual DbSet<Locations> Locations { get; set; }
        public virtual DbSet<Members> Members { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
    }
}
