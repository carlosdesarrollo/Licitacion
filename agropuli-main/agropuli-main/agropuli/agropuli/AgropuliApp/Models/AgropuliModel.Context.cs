﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AgropuliApp.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AgropuliEntities : DbContext
    {
        public AgropuliEntities()
            : base("name=AgropuliEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<OrderProduct> OrderProduct { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Log> Log { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }
        public virtual DbSet<Favor> Favor { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Crop> Crop { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Pest> Pest { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<WorkWithUs> WorkWithUs { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<ServiceCompras> ServiceCompras { get; set; }
        public virtual DbSet<Comentarios> Comentarios { get; set; }
        public virtual DbSet<ServiceCategory> ServiceCategory { get; set; }
        public virtual DbSet<Service> Service { get; set; }
        public virtual DbSet<TypeClient> TypeClient { get; set; }
        public virtual DbSet<TypeProveedor> TypeProveedor { get; set; }
        public virtual DbSet<TypeSubProveedor> TypeSubProveedor { get; set; }
        public virtual DbSet<Ciudad> Ciudad { get; set; }
        public virtual DbSet<Departmento> Departmento { get; set; }
        public virtual DbSet<UsuNivelRef> UsuNivelRef { get; set; }
        public virtual DbSet<NivelRef> NivelRef { get; set; }
    }
}
