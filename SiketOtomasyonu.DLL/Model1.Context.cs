﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SiketOtomasyonu.DLL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SirketOtomasyonDBEntities : DbContext
    {
        public SirketOtomasyonDBEntities()
            : base("name=SirketOtomasyonDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Bankalar> Bankalar { get; set; }
        public virtual DbSet<FaturaDetay> FaturaDetay { get; set; }
        public virtual DbSet<Faturalar> Faturalar { get; set; }
        public virtual DbSet<Gelirler> Gelirler { get; set; }
        public virtual DbSet<Giderler> Giderler { get; set; }
        public virtual DbSet<GiderTurleri> GiderTurleri { get; set; }
        public virtual DbSet<ilceler> ilceler { get; set; }
        public virtual DbSet<iller> iller { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<Markalar> Markalar { get; set; }
        public virtual DbSet<Modeller> Modeller { get; set; }
        public virtual DbSet<MusteriBankaBilgileri> MusteriBankaBilgileri { get; set; }
        public virtual DbSet<Musteriler> Musteriler { get; set; }
        public virtual DbSet<Notlar> Notlar { get; set; }
        public virtual DbSet<Personelizinleri> Personelizinleri { get; set; }
        public virtual DbSet<Personeller> Personeller { get; set; }
        public virtual DbSet<PersonelMaasBilgisi> PersonelMaasBilgisi { get; set; }
        public virtual DbSet<Satislar> Satislar { get; set; }
        public virtual DbSet<SirketBankaBilgileri> SirketBankaBilgileri { get; set; }
        public virtual DbSet<Sirketler> Sirketler { get; set; }
        public virtual DbSet<Urunler> Urunler { get; set; }
        public virtual DbSet<Yetkiler> Yetkiler { get; set; }
        public virtual DbSet<PersonelAyrintisi> PersonelAyrintisi { get; set; }
        public virtual DbSet<PersonelMesaileri> PersonelMesaileri { get; set; }
    
        public virtual ObjectResult<SP_EnAzKalanUrunler_Result> SP_EnAzKalanUrunler()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_EnAzKalanUrunler_Result>("SP_EnAzKalanUrunler");
        }
    }
}
