﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class TP_TCEntities : DbContext
    {
        public TP_TCEntities()
            : base("name=TP_TCEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alquiler> Alquiler { get; set; }
        public virtual DbSet<AUTOR> AUTOR { get; set; }
        public virtual DbSet<CLIENTE> CLIENTE { get; set; }
        public virtual DbSet<DETALLE_ALQUILER> DETALLE_ALQUILER { get; set; }
        public virtual DbSet<EDITORIAL> EDITORIAL { get; set; }
        public virtual DbSet<LIBRO> LIBRO { get; set; }
        public virtual DbSet<MONTO_PAGO> MONTO_PAGO { get; set; }
    }
}
