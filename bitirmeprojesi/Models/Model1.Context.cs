﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace bitirmeprojesi.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bitirme_projesiEntities0 : DbContext
    {
        public bitirme_projesiEntities0()
            : base("name=bitirme_projesiEntities0")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<contact> contact { get; set; }
        public virtual DbSet<mahalleler> mahalleler { get; set; }
        public virtual DbSet<ozgurluk> ozgurluk { get; set; }
        public virtual DbSet<ozgurluk_katlar> ozgurluk_katlar { get; set; }
    }
}
