﻿using ERS_NeoCare.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERS_NeoCare.dbconexion
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() 
        {
            // Habilitar la carga diferida y la característica de navegación automática
            this.Configuration.LazyLoadingEnabled = true;
            this.Configuration.ProxyCreationEnabled = true;
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<Profesion> profesion { get; set; }
        public DbSet<Turno> turnos { get; set; }
        public DbSet<PacienteModel> Pacientes { get; set; }
        public DbSet<HistoriaClinicaModel> HistoriaClinica { get; set; }
        public DbSet<ArchivoEstudio> archivosEstudios { get; set; }
        public DbSet<OrdenModel> orden { get; set; }
        public DbSet<EvaluacionModel> evaluacion { get; set; }
        public DbSet<AtencionEnfermeriaModel> atencion { get; set; }
        public DbSet<AnalisisModel> analisis { get; set; }
        public DbSet<HistorialModel> historial { get; set; }
        public DbSet<TipoAnalisModel> TipoAnalis { get; set; }
    }
}
