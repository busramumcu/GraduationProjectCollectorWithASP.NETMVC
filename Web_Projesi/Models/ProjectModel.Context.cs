﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_Projesi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TezProjectEntities : DbContext
    {
        public TezProjectEntities()
            : base("name=TezProjectEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bekleyen_Kullanici> Bekleyen_Kullanici { get; set; }
        public virtual DbSet<Gorev> Gorevs { get; set; }
        public virtual DbSet<Koordinator> Koordinators { get; set; }
        public virtual DbSet<Kullanici> Kullanicis { get; set; }
        public virtual DbSet<Ogrenci> Ogrencis { get; set; }
        public virtual DbSet<Ogretim_Uyesi> Ogretim_Uyesi { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Tez> Tezs { get; set; }
    }
}
