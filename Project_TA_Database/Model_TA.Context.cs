//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Project_TA_Database
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TAEntities : DbContext
    {
        public TAEntities()
            : base("name=TAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_dosen> tbl_dosen { get; set; }
        public virtual DbSet<tbl_jadwal> tbl_jadwal { get; set; }
        public virtual DbSet<tbl_mhs> tbl_mhs { get; set; }
        public virtual DbSet<tbl_TA> tbl_TA { get; set; }
    }
}
