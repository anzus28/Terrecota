﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructure.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CondominioEntities : DbContext
    {
        public CondominioEntities()
            : base("name=CondominioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AreasComunes> AreasComunes { get; set; }
        public virtual DbSet<Incidencias> Incidencias { get; set; }
        public virtual DbSet<Pagos> Pagos { get; set; }
        public virtual DbSet<pCobro> pCobro { get; set; }
        public virtual DbSet<pCobroDetalle> pCobroDetalle { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Reservaciones> Reservaciones { get; set; }
        public virtual DbSet<Residencia> Residencia { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}