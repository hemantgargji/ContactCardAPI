﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contact.DAL.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ContactBusinessCardEntities1 : DbContext
    {
        public ContactBusinessCardEntities1()
            : base("name=ContactBusinessCardEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<address> addresses { get; set; }
        public virtual DbSet<AddressType> AddressTypes { get; set; }
        public virtual DbSet<country> countries { get; set; }
        public virtual DbSet<organisation> organisations { get; set; }
        public virtual DbSet<position> positions { get; set; }
        public virtual DbSet<slogan> slogans { get; set; }
        public virtual DbSet<state> states { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}