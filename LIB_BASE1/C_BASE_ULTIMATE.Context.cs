﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIB_BASE1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class C_BASE_AZURE : DbContext
    {
        public C_BASE_AZURE()
            : base("name=C_BASE_AZURE")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<C_BOIS> Les_Bois { get; set; }
        public virtual DbSet<C_CLIENT> Les_Clients { get; set; }
        public virtual DbSet<C_GUITARE> Les_Guitares { get; set; }
        public virtual DbSet<C_MICRO> Les_Micros { get; set; }
        public virtual DbSet<C_VIBRATO> Les_Vibratos { get; set; }

        public virtual int DELETE_ALL_BOIS()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_ALL_BOIS");
        }

        public virtual int DELETE_ALL_CLIENT()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_ALL_CLIENT");
        }

        public virtual int DELETE_ALL_GUITARE()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_ALL_GUITARE");
        }

        public virtual int DELETE_ALL_MICRO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_ALL_MICRO");
        }

        public virtual int DELETE_ALL_VIBRATO()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DELETE_ALL_VIBRATO");
        }
    }
}

