﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace POScreen.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SysproCompanyTEntities : DbContext
    {
        public SysproCompanyTEntities()
            : base("name=SysproCompanyTEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<vw_FetchBCFReport> vw_FetchBCFReport { get; set; }
        public virtual DbSet<vw_FetchBOReport> vw_FetchBOReport { get; set; }
        public virtual DbSet<vw_FetchCusSorMaster> vw_FetchCusSorMaster { get; set; }
        public virtual DbSet<ArCustomer> ArCustomers { get; set; }
        public virtual DbSet<vw_FetchPickOrder> vw_FetchPickOrder { get; set; }
        public virtual DbSet<vw_FetchSO> vw_FetchSO { get; set; }
    }
}
