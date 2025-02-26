﻿using Dominio.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructura.Utils
{
    public class SgpContext : DbContext
    {
       // public SgpContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=sgp;Trusted_Connection=True;");
        }

        public DbSet<Beneficiario> Beneficiarios { get; set; }
        public DbSet<Propuesta> Propuestas { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Actividad> Actividades { get; set; }
        public DbSet<CertificadoDeDisponibilidadPresupuestal> CDPs { get; set; }
        public DbSet<Componente> Componente {get; set;}
        public DbSet<Compromiso> Compromiso { get; set; }
        public DbSet<Comunidad> Comunidad { get; set; }
        public DbSet<Convenio> Convenio { get; set; }
        public DbSet<Dimension> Dimension { get; set; }
        public DbSet<DocumentoPresupuestal> DocumentoPresupuestal { get; set; }
        public DbSet<Estrategia> Estrategia { get; set; }
        public DbSet<Programa> Programa { get; set; }
        public DbSet<RegistroPresupuestal> RegistroPresupuestal { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
    }
}
