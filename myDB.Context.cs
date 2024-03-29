﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjGroceryStore4
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class inventoryDBEntities : DbContext
    {
        public inventoryDBEntities()
            : base("name=inventoryDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<purchase> purchases { get; set; }
        public virtual DbSet<purchaseDetail> purchaseDetails { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
    
        public virtual ObjectResult<string> st_getRoleuser(string user)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("st_getRoleuser", userParameter);
        }
    
        public virtual ObjectResult<string> st_getRoleuserNew(string user)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("st_getRoleuserNew", userParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> st_getUserId(string user)
        {
            var userParameter = user != null ?
                new ObjectParameter("user", user) :
                new ObjectParameter("user", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("st_getUserId", userParameter);
        }
    }
}
